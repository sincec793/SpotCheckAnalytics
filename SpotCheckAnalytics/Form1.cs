using System;
using System.Collections;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.OleDb;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using System.Windows.Forms;
using Excel = Microsoft.Office.Interop.Excel;
namespace SpotCheckAnalytics
{
    public partial class Form1 : Form
    {
        Dictionary<string, Employee> dataList = new Dictionary<string, Employee>();
        Dictionary<string, Supervisor> supList = new Dictionary<string, Supervisor>();
        int totalEntries = 0;
        public Form1()
        {          
            InitializeComponent();
        }
        private void closeAllExcelInstances()
        {
            System.Diagnostics.Process[] process = System.Diagnostics.Process.GetProcessesByName("Excel");
            foreach (System.Diagnostics.Process p in process)
            {
                if (!string.IsNullOrEmpty(p.ProcessName))
                {
                    try
                    {
                        p.Kill();
                    }
                    catch { }
                }
            }
        }
        private void Form1_Load(object sender, EventArgs e)
        {
            btnViewAll.Enabled = false;
            btnCommitChanges.Enabled = false;
            btnEmployee.Enabled = false;
            loadDialog.Filter = "Excel Files|*.xls;*.xlsx;*.xlsm";
            textPassword.Text = (string)Properties.Settings.Default["ExcelPassword"];
            textDefault.Text = (string)Properties.Settings.Default["DefaultLocation"];
            checkDefault.Checked = (bool)Properties.Settings.Default["UseDefaultLocation"];
            checkAutoChart.Checked = (bool)Properties.Settings.Default["AutoGraph"];
            closeAllExcelInstances();
            
        }
        
        private IDictionary importFromExcel(string path)
        {
            txtNotification.Text = "Loading Started, please wait...";
            Dictionary<string, Employee> tempList = new Dictionary<string, Employee>();
            try
            {
                
                string password = (string)Properties.Settings.Default["ExcelPassword"];
                Excel.Application xlApp = new Excel.Application();
                Excel.Workbook xlWorkBook = xlApp.Workbooks.Open(path, 0, false, 5, password);
                
                Excel.Worksheet xlSheet = (Excel.Worksheet)xlWorkBook.Worksheets.Item["Detail"];
                Excel.Range range = xlSheet.UsedRange;
                int errorCount = 0;
                for (int i = 3; i <= range.Rows.Count; i++)
                {
                    try
                    {
                        string name = (string)(range.Cells[i, 2] as Excel.Range).Value2 + " " + (string)(range.Cells[i, 1] as Excel.Range).Value2;
                        name = name.TrimStart();
                        name = name.TrimEnd();
                        name = Regex.Replace(name, @"\s+", " ");
                        name = System.Threading.Thread.CurrentThread.CurrentCulture.TextInfo.ToTitleCase(name);
                        string supname = (string)(range.Cells[i, 3] as Excel.Range).Value2;
                        supname = supname.TrimStart();
                        supname = supname.TrimEnd();
                        string[] parts = supname.Split('/');
                        supname = parts[0];
                        supname = Regex.Replace(supname, @"\s+", " ");                
                      
                        supname = System.Threading.Thread.CurrentThread.CurrentCulture.TextInfo.ToTitleCase(supname);
                        string score = (string)(range.Cells[i, 6] as Excel.Range).Value2;
                        string date = Convert.ToString((range.Cells[i, 4] as Excel.Range).Value2);
                        Employee temp = new Employee();
                        SpotCheck tempCheck = new SpotCheck();
                        Supervisor tempSup = new Supervisor();
                        if (!tempList.ContainsKey(name)) //If we dont have that name stored
                        {
                            if (!supList.ContainsKey(supname))
                            {
                                tempSup.setName(supname);
                                supList.Add(supname, tempSup);
                            }
                            if (score.ToLower().Contains("exc"))
                            {
                                temp.setExceeds(1);
                                supList[supname].setExceeds(supList[supname].getExceeds() + 1);
                                tempCheck.setScore("Exceeds");

                            }
                            if (score.ToLower().Contains("rec") || score.Contains("me"))
                            {
                                temp.setRectify(1);
                                supList[supname].setRectify(supList[supname].getRectifys() + 1);
                                tempCheck.setScore("Rectify");

                            }
                            if (score.ToLower().Contains("fa"))
                            {
                                temp.setFails(1);
                                supList[supname].setFails(supList[supname].getFails() + 1);
                                tempCheck.setScore("Fails");

                            }
                           
                            
                            tempCheck.setDate(date);
                            temp.addCheck(tempCheck);
                            temp.setName(name);
                            tempList.Add(name, temp);
                        }
                        else
                        {
                            temp = tempList[name];
                            int num = 0;
                            if (!supList.ContainsKey(supname))
                            {
                                tempSup.setName(supname);
                                supList.Add(supname, tempSup);
                            }
                            if (score.ToLower().Contains("exc"))
                            {
                                num = temp.getExceeds();
                                temp.setExceeds(1 + num);
                                supList[supname].setExceeds(supList[supname].getExceeds() + 1);
                                tempCheck.setScore("Exceeds");

                            }
                            if (score.ToLower().Contains("rec") || score.ToLower().Contains("me"))
                            {
                                num = temp.getRectifys();
                                temp.setRectify(1 + num);
                                supList[supname].setRectify(supList[supname].getRectifys() + 1);
                                tempCheck.setScore("Rectify");

                            }
                            if (score.ToLower().Contains("fa"))
                            {
                                num = temp.getFails();
                                temp.setFails(1 + num);
                                supList[supname].setFails(supList[supname].getFails() + 1);
                                tempCheck.setScore("Fails");

                            }
                           
                            tempCheck.setDate(date);
                            temp.addCheck(tempCheck);
                        }
                    }
                    catch (Exception e)
                    {
                        errorCount++;
                        if (errorCount > 20)
                        {
                            break;
                        }
                    }
                }
                xlWorkBook.Close(0);
                xlApp.Quit();
                System.Runtime.InteropServices.Marshal.ReleaseComObject(xlApp);
                btnEmployee.Enabled = true;
                btnViewAll.Enabled = true;
            }
            catch(Exception e)
            {
                MessageBox.Show(e.Message);
            }
           
            
            return tempList;
        }
        private string findMostSimilar(string n, Dictionary<string, Employee> list, float threshold)
        {
            float bestMatch = 0;
            string bestName = "";

            foreach(string key in list.Keys)
            {
                MatchsMaker matchCalc = new MatchsMaker(n, key);
                Console.WriteLine(matchCalc.Score);
                if(matchCalc.Score > bestMatch && matchCalc.Score > threshold)
                {
                    bestName = key;
                }
            }
            if (bestName.Equals(""))
            {
                bestName = n;
            }
            return bestName;
        }
        private void calcTopPerformers()
        {
            totalEntries = 0;
            foreach (Employee emp in dataList.Values)
            {
                totalEntries += emp.getExceeds();
                totalEntries += emp.getRectifys();
                totalEntries += emp.getFails();
            }
            dataPerformance.Rows.Clear();
            foreach (Employee emp in dataList.Values)
            {
                emp.sortChecks();
                int count = dataPerformance.Rows.Add();
                int sum = emp.getExceeds() + emp.getRectifys() + emp.getFails();
                int streak = emp.calcStreak();
             
                dataPerformance.Rows[count].Cells[0].Value = emp.getName();
                dataPerformance.Rows[count].Cells[1].Value = emp.getExceeds();
                dataPerformance.Rows[count].Cells[2].Value = emp.getRectifys();
                dataPerformance.Rows[count].Cells[3].Value = emp.getFails();
                dataPerformance.Rows[count].Cells[4].Value = Math.Round((totalEntries * (emp.getExceeds() + emp.getRectifys()/1.5)/sum) * (1 - (emp.getFails() / sum)),0) + streak;
                dataPerformance.Rows[count].Cells[5].Value = streak;
            }
            this.dataPerformance.Sort(this.dataPerformance.Columns["Score"], ListSortDirection.Descending);
            if ((bool)Properties.Settings.Default["AutoGraph"])
            {
                chartOverall();
            }
        }
        private void tableLayoutPanel1_Paint(object sender, PaintEventArgs e)
        {

        }
        private void chartOverall()
        {
            int ex = 0;
            int rec = 0;
            int fail = 0;
            int sum;
            foreach (Employee emp in dataList.Values)
            {
                ex += emp.getExceeds();
                rec += emp.getRectifys();
                fail += emp.getFails();
            }
            sum = ex + rec + fail;
            chartEmployee.Series.Clear();
            chartEmployee.Titles["MainTitle"].Text = "Overall Employee Performance";
            chartEmployee.Titles["Count"].Text = "Total Entries: " + sum;
            chartEmployee.Series.Add("Performance");
            chartEmployee.Series["Performance"].ChartType = System.Windows.Forms.DataVisualization.Charting.SeriesChartType.Doughnut;
            chartEmployee.Series["Performance"].Points.AddXY("Exceeds", ex);
            chartEmployee.Series["Performance"].Points.AddXY("Rectifys", rec);
            chartEmployee.Series["Performance"].Points.AddXY("Fails", fail);
            chartEmployee.Series["Performance"].Label = "#VALX #PERCENT{P0}";
        }
        private void button1_Click(object sender, EventArgs e) //Viewall
        {
            chartOverall();
        }

        private void loadDataToolStripMenuItem_Click(object sender, EventArgs e)
        {
           
            if((bool)Properties.Settings.Default["UseDefaultLocation"] == false)
            {
                DialogResult result = loadDialog.ShowDialog(); // Show the dialog.
                if (result == DialogResult.OK) // Test result.
                {
                    string file = loadDialog.FileName;
                    dataList.Clear();
                    
                    dataList = (Dictionary<string, Employee>)importFromExcel(file);
                    listEmployees.Items.Clear();
                    foreach (string str in dataList.Keys)
                    {
                        listEmployees.Items.Add(str);
                    }
                    foreach (string str in supList.Keys)
                    {
                        listSupervisors.Items.Add(str);
                    }
                    lblGuardCount.Text = "Total Guards: " + dataList.Count;
                    calcTopPerformers();
                    txtNotification.Text = "Load Complete";
                }
            }else
            {
                string location = (string)Properties.Settings.Default["DefaultLocation"];
                if (location != "")
                {
                    dataList.Clear();
                    dataList = (Dictionary<string, Employee>)importFromExcel(location);
                  
                    listEmployees.Items.Clear();
                    foreach (string str in dataList.Keys)
                    {
                        listEmployees.Items.Add(str);
                    }
                    foreach(string str in supList.Keys)
                    {
                        listSupervisors.Items.Add(str);
                    }
                    lblGuardCount.Text = "Total Guards: " + dataList.Count;
                    calcTopPerformers();
                    txtNotification.Text = "Load Complete";
                }
                else
                {
                    MessageBox.Show("No path has been given to load by default. Please change this under the settings tab.");
                }
            }
          
            
        }
        //Not working
        private Dictionary<string, Employee> eliminateSimilarNames(Dictionary<string, Employee> list, float threshold)
        {
            Dictionary<string, Employee> list2 = new Dictionary<string,Employee>();
            for(int i = 0; i < list.Count; i += 2)
            {
                string key1, key2;
                key1 = list.ElementAt(i).Key;
                key2 = list.ElementAt(i + 1).Key;
                MatchsMaker matcher = new MatchsMaker(list[key1].getName(), list[list.ElementAt(i + 1).Key].getName());
                if(matcher.Score > threshold)
                {
                    //Combine
                    if(list[key1].getTotalChecks() > list[key2].getTotalChecks())
                    {
                        foreach (SpotCheck check in list[key2].getChecks())
                        {
                            list[key1].addCheck(check);
                        }
                        list[key1].setExceeds(list[key1].getExceeds() + list[key2].getExceeds());
                        list[key1].setRectify(list[key1].getRectifys() + list[key2].getRectifys());
                        list[key1].setFails(list[key1].getFails() + list[key2].getFails());
                        list[key1].calcStreak();
                        list[key1].setTotalChecks();
                        list2.Add(key1, list[key1]);
                    }
                    else
                    {
                        foreach (SpotCheck check in list[key1].getChecks())
                        {
                            list[key2].addCheck(check);
                        }
                        list[key2].setExceeds(list[key1].getExceeds() + list[key2].getExceeds());
                        list[key2].setRectify(list[key1].getRectifys() + list[key2].getRectifys());
                        list[key2].setFails(list[key1].getFails() + list[key2].getFails());
                        list[key2].calcStreak();
                        list[key2].setTotalChecks();
                        list2.Add(key2, list[key2]);
                    }

                }else
                {
                    list2.Add(key1, list[key1]);
                }
            }
            return list2;
        }
        private void btnEmployee_Click(object sender, EventArgs e)
        {
            if(listEmployees.SelectedItem != null)
            {
                Employee currEmployee = dataList[(string)listEmployees.SelectedItem];
                int sum = currEmployee.getExceeds() + currEmployee.getRectifys() + currEmployee.getFails();
                chartEmployee.Series.Clear();
                chartEmployee.Titles["MainTitle"].Text = "Employee Performance of " + currEmployee.getName();
                chartEmployee.Titles["Count"].Text = "Total Entries: " + sum;

                chartEmployee.Series.Add("Performance");
                chartEmployee.Series["Performance"].ChartType = System.Windows.Forms.DataVisualization.Charting.SeriesChartType.Doughnut;
                chartEmployee.Series["Performance"].Points.AddXY("Exceeds", currEmployee.getExceeds());
                chartEmployee.Series["Performance"].Points.AddXY("Rectifys", currEmployee.getRectifys());
                chartEmployee.Series["Performance"].Points.AddXY("Fails", currEmployee.getFails());
                chartEmployee.Series["Performance"].Label = "#VALX #PERCENT{P0}";
            }
            else
            {
                MessageBox.Show("Please select an employee");
            }
        }

        private void dataPerformance_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void exitToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
        
        private void settingsToolStripMenuItem_Click_1(object sender, EventArgs e)
        {
           
        }

        private void editToolStripMenuItem_Click(object sender, EventArgs e)
        {          

            
        }

        private void button1_Click_1(object sender, EventArgs e)
        {
            Properties.Settings.Default["ExcelPassword"] = textPassword.Text;
            Properties.Settings.Default["AutoGraph"] = checkAutoChart.Checked;
            Properties.Settings.Default["UseDefaultLocation"] = checkDefault.Checked;
            Properties.Settings.Default["DefaultLocation"] = textDefault.Text;
            Properties.Settings.Default.Save();
            btnCommitChanges.Enabled = false;
        }

        private void btnSetDefault_Click(object sender, EventArgs e)
        {
            DialogResult result = loadDialog.ShowDialog(); // Show the dialog.
            if (result == DialogResult.OK) // Test result.
            {
                string file = loadDialog.FileName;
                textDefault.Text = file;
                
            }
        }

        private void toolStripTextBox1_Click(object sender, EventArgs e)
        {

        }

        private void textPassword_TextChanged(object sender, EventArgs e)
        {
            btnCommitChanges.Enabled = true;
           
        }

        private void textDefault_TextChanged(object sender, EventArgs e)
        {
            btnCommitChanges.Enabled = true;
           
        }

        private void checkDefault_CheckedChanged(object sender, EventArgs e)
        {
            btnCommitChanges.Enabled = true;
            
        }

        private void checkAutoChart_CheckedChanged(object sender, EventArgs e)
        {
            btnCommitChanges.Enabled = true;
           
        }
        
        private void listSupervisors_SelectedIndexChanged_1(object sender, EventArgs e)
        {
           
        }

        private void btnViewSup_Click(object sender, EventArgs e)
        {
            if (listSupervisors.SelectedItem != null)
            {
                Supervisor currEmployee = supList[(string)listSupervisors.SelectedItem];
                int sum = currEmployee.getExceeds() + currEmployee.getRectifys() + currEmployee.getFails();
                chartSupervisor.Series.Clear();
                chartSupervisor.Titles["MainTitle"].Text = "Spot Checks given by " + currEmployee.getName();
                chartSupervisor.Titles["Count"].Text = "Total Checks Given: " + sum;

                chartSupervisor.Series.Add("Performance");
                chartSupervisor.Series["Performance"].ChartType = System.Windows.Forms.DataVisualization.Charting.SeriesChartType.Doughnut;
                chartSupervisor.Series["Performance"].Points.AddXY("Exceeds", currEmployee.getExceeds());
                chartSupervisor.Series["Performance"].Points.AddXY("Rectifys", currEmployee.getRectifys());
                chartSupervisor.Series["Performance"].Points.AddXY("Fails", currEmployee.getFails());
                chartSupervisor.Series["Performance"].Label = "#VALX #PERCENT{P0}";
            }
            else
            {
                MessageBox.Show("Please select an employee");
            }
        }
    }
}

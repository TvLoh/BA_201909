using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO.Ports;
using System.IO;



namespace GUI_VD30
{


    public partial class Form1 : Form
    {
        bool data_start_var = false;

        int zoomfactor = 0;
        int _ticks = 0;

        double mouse_x_pos = 0;
        double mouse_y_pos = 0;

        int[] data_in_array_int = new int[6];
        byte[] data_in_array_byte = new byte[6];

        string[] data_in_array = new string[4];
        string[] data_chart = new string[6];


        public Form1()
        {

            InitializeComponent();
            
            chart1.MouseWheel += chart1_Mousewheel;
            chart2.MouseWheel += chart2_Mousewheel;
            chart3.MouseWheel += chart3_Mousewheel;
        }

        private void Timer_send_data_Tick(object sender, EventArgs e)
        {
            _ticks++;
            tsl_timer.Text = _ticks.ToString();
        }

        //---------------------------------------------------------------------------------------------------------------------------------------------------
        //--------------------------------------------------------------------- Tap one -----------------------------------------------------------------
        //---------------------------------------------------------------------------------------------------------------------------------------------------


        private void Cb_serial_data_com_port_DropDown(object sender, EventArgs e)               //--- initialise available COM-PORT when dropdown ---
        {
            cb_serial_data_com_port.Items.Clear();                                              // Clear Itams of COM PORT
            cb_serial_data_com_port.Items.AddRange(SerialPort.GetPortNames());                  // Load all COM PORT that available at the moment
        }


        private void Cb_serial_data_dtr_enable_CheckedChanged(object sender, EventArgs e)       //--- Enables Data Terminal Ready (DTR) "part of RS232" ---
        {
            if (cb_serial_data_dtr_enable.Checked)
            {
                serialPort1.DtrEnable = true;
                MessageBox.Show("DTR Enabled", "Information", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            else
            {
                serialPort1.DtrEnable = false;
            }
        }

        private void Cb_serial_data_rts_enable_CheckedChanged(object sender, EventArgs e)       //--- Enables flow controll mechanism (RTS) "part of RS232"---
        {
            if (cb_serial_data_rts_enable.Checked)
            {
                serialPort1.RtsEnable = true;
                MessageBox.Show("RTS Enabled", "Information", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            else
            {
                serialPort1.RtsEnable = false;
            }
        }

        private void Btn_serial_data_open_Click(object sender, EventArgs e)                     //--- Open COM PORT ---
        {
            try
            {
                                                                                                //Settings Serial Port
                serialPort1.PortName = cb_serial_data_com_port.Text;
                serialPort1.BaudRate = Convert.ToInt32(cb_serial_data_baudrate.Text);
                serialPort1.DataBits = Convert.ToInt32(cb_serial_data_data_bits.Text);
                serialPort1.Parity = (Parity)Enum.Parse(typeof(StopBits), cb_serial_data_parity_bits.Text);
                serialPort1.StopBits = (StopBits)Enum.Parse(typeof(StopBits), cb_serial_data_stop_bits.Text);
                serialPort1.ReadTimeout = 60;
                serialPort1.WriteTimeout = 200;

                serialPort1.Open();
                pb_serial_data_status.Value = 100;                                              // set processbar to 100%

                tb_serial_data_out.Enabled = true;                                              // set state for opperating system ...
                btn_serial_data_clear.Enabled = true;
                btn_serial_data_close.Enabled = true;
                btn_serial_data_send.Enabled = true;
                btn_serial_data_open.Enabled = false;

            }
            catch (Exception err)                                                                // open Error Message when something goes wrong
            {                                                                                    // set default state ...
                tb_serial_data_out.Enabled = false;
                btn_serial_data_clear.Enabled = false;
                btn_serial_data_close.Enabled = false;
                btn_serial_data_send.Enabled = false;
                btn_serial_data_open.Enabled = true;

                MessageBox.Show(err.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            timer_send_data.Start();
        }

        private void Btn_serial_data_close_Click(object sender, EventArgs e)                    //--- close COM PORT -- 
        {
            if (serialPort1.IsOpen)
            {
                serialPort1.Close();                                                            // close COM PORT
                                         
                tb_serial_data_out.Enabled = false;                                             // set default state ...
                btn_serial_data_close.Enabled = false;
                btn_serial_data_send.Enabled = false;
                btn_serial_data_open.Enabled = true;

                pb_serial_data_status.Value = 0;
            }
        }

        private void Tb_serial_data_out_KeyDown(object sender, KeyEventArgs e)                  //--- send serialData via Enter ---
        {
            if (e.KeyCode == Keys.Enter)                                                        // watch for input Enter
            {
                this.send_data_serialPort();                                                    // execute Funktion send_data_serialPort
                e.Handled = true; 
                e.SuppressKeyPress = true;                                                      // eliminate Funktion of Enter
            }
        }

        private void Btn_serial_data_send_Click(object sender, EventArgs e)                     //--- send serialData via Button ---
        {
            this.send_data_serialPort();                                                        // execute Funktion send_data_serialPort
        }

        private void send_data_serialPort()                                                     //--- Funktion: send_data_serialPort ---
        {
            if (serialPort1.IsOpen)                                                             // check if serialPort is open
            {
                serialPort1.Write(tb_serial_data_out.Text);                                     // send Text from tb_serial_data_out
                tb_serial_data_out.Text = "";                                                   // delete Text in tb_serial_data_out
            }
            else 
            {
                MessageBox.Show("","Warning, serialPort is closed.", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }
        private void Tb_serial_data_out_TextChanged(object sender, EventArgs e)                 //--- count Taxt in tb_serial_data_out ---
        {
            lbl_data_out_length.Text = string.Format("{0:00}", tb_serial_data_out.Text.Length);
        }

        private void Tb_serial_data_receive_TextChanged(object sender, EventArgs e)             //--- count Taxt in tb_serial_data_receive ---
        {
            lbl_data_in_length.Text = string.Format("{0:00}",tb_serial_data_receive.Text.Length);
        }

        private void SerialPort1_DataReceived(object sender, SerialDataReceivedEventArgs e)     //--- manage Event (dosent worke otherwise) ---
        {
            this.Invoke(new EventHandler(show_data));
        }

        private void Btn_serial_data_clear_Click(object sender, EventArgs e)                    //--- clear Text in output Monitor ----
        {
            tb_serial_data_receive.Text = "";
        }


        //---------------------------------------------------------------------------------------------------------------------------------------------------
        //--------------------------------------------------------------------- Receive Data -----------------------------------------------------------------
        //---------------------------------------------------------------------------------------------------------------------------------------------------

        private void show_data(object sender, EventArgs e)                                      //--- Funktion for manage the incoming data ---
        {
            int rotation_speed = 50;
            string datetime = DateTime.Now.ToString("HH.mm.ss");                                // generate variable with current time
            string data_in;
            // Array's were defined global in "public partial class Form1 : Form" at the beginning

            try
            {
                data_in = serialPort1.ReadLine().ToString();
                tb_serial_data_receive.AppendText(data_in);                                         // merge incoming Data to received data
                data_in_array = data_in.Split(':', ',');                                        // split the inkomming data String at , and :

            }
            catch (TimeoutException err)
            {
                MessageBox.Show(err.Message, "Warnig", MessageBoxButtons.OK);
            }            

            //tb_serial_data_receive.Text += data_in;                                           // data-set for Textbox Com Port Monitor
            //tb_serial_data_receive.ScrollToCaret();

            //if(data_in_array[0] == "0" || data_start_var == true)                        // only for debugging
            //{
            //    data_start_var = true;

                data_in_array_int[1] = int.Parse(data_in_array[1]);                            // convert values to int
                data_in_array_int[2] = int.Parse(data_in_array[2]);
                data_in_array_int[3] = int.Parse(data_in_array[3]);

            //rotation_speed = data_in_array_int[3];                                        // only for debugging


            if (1 < data_in_array_int[3] && data_in_array_int[3] < 251)                     // manage rotation_speed: recceived data between 0 and 251. Otherwise the DM30 stands still.
            {
                rotation_speed = 60000 / (2 * data_in_array_int[3]);
            }
            else
            {
                rotation_speed = 0;
            }
            
            // --- build Chart's
            chart1.Series[0].Points.AddXY(datetime, data_in_array_int[1]);                  // set values for Graph 
            chart2.Series[0].Points.AddXY(datetime, data_in_array_int[2]);
            chart3.Series[0].Points.AddXY(datetime, rotation_speed);

            chart1.Series[0].LegendText = "Force Tower";
            chart2.Series[0].LegendText = "Force Nacelle";
            chart3.Series[0].LegendText = "rotation Speed";

            dgv_data_datakontainer.Rows.Add(datetime, data_in_array_int[1], data_in_array_int[2], rotation_speed.ToString(), nud_control_pos_brake.Value, nud_control_pos_blade_01.Value, nud_control_pos_blade_02.Value, nud_control_pos_blade_03.Value);
            dgv_data_datakontainer.FirstDisplayedScrollingRowIndex = dgv_data_datakontainer.RowCount - 1;
            //}

            /*                                                                                  // only for debugging
            if (data_in_array[0].Contains("1"))                                                 // like switch case: search for char in string. Load al arrays with values into one single array. Have a look at the incoming String (array[i]:value, "newline").
            {
                data_chart[0] = data_in_array[0];                   
                data_chart[1] = data_in_array[1];
            }
            else if (data_in_array[0].Contains("2"))
            {
                data_chart[2] = data_in_array[0];
                data_chart[3] = data_in_array[1];
            }
            else if (data_in_array[0].Contains("3"))

            {
                data_chart[4] = data_in_array[0];
                data_chart[5] = data_in_array[1];

                data_in_array_int[1] = int.Parse(data_chart[1]);                                // convert values to int
                data_in_array_int[3] = int.Parse(data_chart[3]);
                data_in_array_int[5] = int.Parse(data_chart[5]);

                if (100 < data_in_array_int[5] && data_in_array_int[5] < 251)                     // manage rotation_speed: recceived data between 0 and 251. Otherwise the DM30 stands still.
                {
                    rotation_speed = 600000 /(2* data_in_array_int[5]);
                }
                else
                {
                    rotation_speed = 0;
                }

                // --- build Chart's

                chart1.Series[0].Points.AddXY(datetime, data_in_array_int[1]);                  // set values for Graph 
                chart2.Series[0].Points.AddXY(datetime, data_in_array_int[3]);
                chart3.Series[0].Points.AddXY(datetime, rotation_speed);

                chart1.Series[0].LegendText = "Force Tower";
                chart2.Series[0].LegendText = "Force Nacelle";
                chart3.Series[0].LegendText = "rotation Speed";

                dgv_data_datakontainer.Rows.Add(datetime, data_chart[1],data_chart[3], rotation_speed.ToString(),nud_control_pos_brake.Value,nud_control_pos_blade_01.Value,nud_control_pos_blade_02.Value,nud_control_pos_blade_03.Value);
                dgv_data_datakontainer.FirstDisplayedScrollingRowIndex = dgv_data_datakontainer.RowCount - 1;
                

            }
                        */
        }

        //---------------------------------------------------------------------------------------------------------------------------------------------------
        //--------------------------------------------------------------------- Tab two ---------------------------------------------------------------------
        //---------------------------------------------------------------- manipulate chart -----------------------------------------------------------------
        //---------------------------------------------------------------------------------------------------------------------------------------------------


        private void Data_chart1_MouseMove(object sender, MouseEventArgs e)
        {
            mouse_x_pos = chart1.ChartAreas[0].AxisX.PixelPositionToValue(e.X);                 // Get the x-value nearby the Mouse position
            mouse_y_pos = chart1.ChartAreas[0].AxisY.PixelPositionToValue(e.Y);                 // Get the y-value nearby the Mouse position
            tsl_mause_x.Text = " MausePos. X: " + mouse_x_pos.ToString("F2") + " ";
            tsl_mause_y.Text = " MausePos. Y: " + mouse_y_pos.ToString("F2") + " ";
        }

        private void Chart2_MouseMove(object sender, MouseEventArgs e)
        {
            mouse_x_pos = chart2.ChartAreas[0].AxisX.PixelPositionToValue(e.X);                 // Get the x-value nearby the Mouse position
            mouse_y_pos = chart2.ChartAreas[0].AxisY.PixelPositionToValue(e.Y);                 // Get the y-value nearby the Mouse position
            tsl_mause_x.Text = " MausePos. X: " + mouse_x_pos.ToString("F2") + " ";
            tsl_mause_y.Text = " MausePos. Y: " + mouse_y_pos.ToString("F2") + " ";
        }

        private void Chart3_MouseMove(object sender, MouseEventArgs e)
        {
            mouse_x_pos = chart3.ChartAreas[0].AxisX.PixelPositionToValue(e.X);                 // Get the x-value nearby the Mouse position
            mouse_y_pos = chart3.ChartAreas[0].AxisY.PixelPositionToValue(e.Y);                 // Get the y-value nearby the Mouse position
            tsl_mause_x.Text = " MausePos. X: " + mouse_x_pos.ToString("F2") + " ";
            tsl_mause_y.Text = " MausePos. Y: " + mouse_y_pos.ToString("F2") + " ";
        }
        private void chart1_Mousewheel(object sender, MouseEventArgs e)                         // Evenet: If Mousewheel rotate
        {
            try
            {
                if (e.Delta > 0)                                                                // check rotation direction of Mousewheel
                {
                    zoomfactor++;                                                               //increment zoomfactor
                }
                else if(zoomfactor > 0)                                                         // zoom factor must be greater than -1
                {
                    zoomfactor--;                                                               // decrement zoomfactor
                }
            }
            catch (Exception err)                                                               // Errormessage is something goes wrong
            {
                MessageBox.Show(err.Message,"Warning", MessageBoxButtons.OK,MessageBoxIcon.Error);
            }
            this.zoom_graph();
        }
        private void chart2_Mousewheel(object sender, MouseEventArgs e)                         // Evenet: If Mousewheel rotate
        {
            try
            {
                if (e.Delta > 0)                                                                // check rotation direction of Mousewheel
                {
                    zoomfactor++;                                                               //increment zoomfactor
                }
                else if(zoomfactor > 0)                                                         // zoom factor must be greater than -1
                {
                    zoomfactor--;                                                               // decrement zoomfactor
                }
            }
            catch (Exception err)                                                               // Errormessage is something goes wrong
            {
                MessageBox.Show(err.Message, "Warning", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            this.zoom_graph();
        }
        private void chart3_Mousewheel(object sender, MouseEventArgs e)                         // Evenet: If Mousewheel rotate
        {
            try
            {
                if (e.Delta > 0)                                                                // check rotation direction of Mousewheel
                {
                    zoomfactor++;                                                               // increment zoomfactor
                }
                else if (zoomfactor > 0)                                                        // zoom factor must be greater than -1
                {
                    zoomfactor--;                                                               // decrement zoomfactor
                }
            }
            catch (Exception err)                                                               // Errormessage is something goes wrong
            {
                MessageBox.Show(err.Message, "Warning", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            this.zoom_graph();
        }

        private void zoom_graph()
        {
            var x_min = chart3.ChartAreas[0].AxisX.Minimum;
            var x_max = chart3.ChartAreas[0].AxisX.Maximum;
            var posXStart = mouse_x_pos - (x_max - x_min) / zoomfactor;                         // calc value for zoom intervall
            var posXFinish = mouse_x_pos + (x_max - x_min) / zoomfactor;                        // calc value for zoom intervall

            chart1.ChartAreas[0].AxisX.ScaleView.Zoom(posXStart, posXFinish);                   // zoom into zoom intervall
            chart2.ChartAreas[0].AxisX.ScaleView.Zoom(posXStart, posXFinish);                   // zoom into zoom intervall
            chart3.ChartAreas[0].AxisX.ScaleView.Zoom(posXStart, posXFinish);                   // zoom into zoom intervall

            tsl_zoomfactor.Text = " Zoom X-Axis: " + zoomfactor.ToString() +" ";                // Display the zoom faktor

        }

        //---------------------------------------------------------------------------------------------------------------------------------------------------
        //--------------------------------------------------------------------- Blade control ---------------------------------------------------------------------
        //---------------------------------------------------------------------------------------------------------------------------------------------------

        private void Cb_controll_simultainiously_CheckedChanged(object sender, EventArgs e)     //--- set GUI design ---
        {
            if (cb_controll_simultaeously.Checked)                                            // disable control if sim. checked ...
            {
                lbl_pos_blade_02.Enabled = false;
                lbl_pos_blade_03.Enabled = false;
                nud_control_pos_blade_02.Enabled = false;
                nud_control_pos_blade_03.Enabled = false;
                tbs_control_pos_blade_02.Enabled = false;
                tbs_control_pos_blade_03.Enabled = false;
                nud_control_pos_blade_02.Value = nud_control_pos_blade_01.Value;
                nud_control_pos_blade_03.Value = nud_control_pos_blade_01.Value;
            }
            else                                                                                // enable control if sim. is unchecked ...

            {
                lbl_pos_blade_02.Enabled = true;
                lbl_pos_blade_03.Enabled = true;
                nud_control_pos_blade_02.Enabled = true;
                nud_control_pos_blade_03.Enabled = true;
                tbs_control_pos_blade_02.Enabled = true;
                tbs_control_pos_blade_03.Enabled = true;
            }
        }


        private void send_control_data()                                                   //--- build and send String to Arduino ---
        {
            string send_string = "";
            if (_ticks > 3)
            {
                try
                {
                    if (serialPort1.IsOpen)
                    {
                        if (cb_controll_simultaeously.Checked == false)                                             // check Blade should become the same position
                        {
                            send_string = nud_control_pos_brake.Value.ToString() + ","
                            + nud_control_pos_blade_01.Value.ToString() + ","
                            + nud_control_pos_blade_02.Value.ToString() + ","
                            + nud_control_pos_blade_03.Value.ToString();
                            //serialPort1.Write(send_string);
                        }
                        else
                        {
                            send_string = nud_control_pos_brake.Value.ToString() + ","
                            + nud_control_pos_blade_01.Value.ToString() + ","
                            + nud_control_pos_blade_01.Value.ToString() + ","
                            + nud_control_pos_blade_01.Value.ToString();
                        }
                        serialPort1.Write(send_string);
                    }
                    else
                    {
                        MessageBox.Show("Error", "Error, serial Port is closed", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                }
                catch (Exception err)
                {
                    MessageBox.Show(err.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                _ticks = 0;
            }
        }


        private void Nud_control_pos_blade_01_ValueChanged(object sender, EventArgs e)          //--- sync. input ---
        {
            tbs_control_pos_blade_01.Value = int.Parse(nud_control_pos_blade_01.Value.ToString());

            if (cb_controll_simultaeously.Checked)
            {
                nud_control_pos_blade_02.Value = nud_control_pos_blade_01.Value;
                nud_control_pos_blade_03.Value = nud_control_pos_blade_01.Value;
                this.send_control_data();
            }
        }

        private void Tbs_control_pos_blade_01_MouseUp(object sender, MouseEventArgs e)
        {
            nud_control_pos_blade_01.Value = tbs_control_pos_blade_01.Value;

            if (cb_controll_simultaeously.Checked)
            {
                nud_control_pos_blade_02.Value = nud_control_pos_blade_01.Value;
                nud_control_pos_blade_03.Value = nud_control_pos_blade_01.Value;
                this.send_control_data();
            }
        }
        private void Tbs_control_pos_blade_01_Scroll(object sender, EventArgs e)                    //--- sync. input ---
        {
            nud_control_pos_blade_01.Value = tbs_control_pos_blade_01.Value;
        }

        private void Nud_control_pos_blade_02_ValueChanged(object sender, EventArgs e)              //--- sync. input ---
        {
            tbs_control_pos_blade_02.Value = int.Parse(nud_control_pos_blade_02.Value.ToString());
        }

        private void Tbs_control_pos_blade_02_Scroll(object sender, EventArgs e)                    //--- sync. input ---
        {
            nud_control_pos_blade_02.Value = tbs_control_pos_blade_02.Value;
        }

        private void Nud_control_pos_blade_03_ValueChanged(object sender, EventArgs e)              //--- sync. input ---
        {
            tbs_control_pos_blade_03.Value = int.Parse(nud_control_pos_blade_03.Value.ToString());
        }

        private void Tbs_control_pos_blade_03_Scroll(object sender, EventArgs e)                    //--- sync. input ---
        {
            nud_control_pos_blade_03.Value = tbs_control_pos_blade_03.Value;
        }

        private void Nud_control_pos_brake_Scroll(object sender, ScrollEventArgs e)
        {
            tbs_control_pos_brake.Value = int.Parse(nud_control_pos_brake.Value.ToString());
            this.send_control_data();
        }

        private void Nud_control_pos_brake_ValueChanged_1(object sender, EventArgs e)
        {
            tbs_control_pos_brake.Value = int.Parse(nud_control_pos_brake.Value.ToString());
            this.send_control_data();
        }

        private void Tbs_control_pos_brake_MouseUp(object sender, MouseEventArgs e)
        {
            nud_control_pos_brake.Value = tbs_control_pos_brake.Value;
            this.send_control_data();
        }

        private void Tb_control_pos_brake_Scroll(object sender, EventArgs e)                //--- sync. input ---
        {
            nud_control_pos_brake.Value = tbs_control_pos_brake.Value;
        }

        private void Btn_control_send_blade_pos_Click(object sender, EventArgs e)          //--- sync. input ---
        {
            this.send_control_data();
        }



        private void Tsb_save_txt_Click(object sender, EventArgs e)
        {
            SaveFileDialog save_file_dialog_01 = new SaveFileDialog();
            save_file_dialog_01.Filter = "txt files (*.txt)|*.txt|All files (*.*)|*.*";
            save_file_dialog_01.FilterIndex = 2;
            save_file_dialog_01.RestoreDirectory = true;

            if (save_file_dialog_01.ShowDialog() == DialogResult.OK)
            {
                using (Stream s = File.Open(save_file_dialog_01.FileName, FileMode.Create))
                using (StreamWriter file = new StreamWriter(s))
                {
                    for (int i = 0; i < dgv_data_datakontainer.Rows.Count - 1; i++)
                    {
                        for (int j = 0; j < dgv_data_datakontainer.Columns.Count - 1; j++)
                        {
                            file.Write(dgv_data_datakontainer.Rows[i].Cells[j].Value);
                            file.Write("\t\t|");
                        }
                        file.WriteLine("");
                    }
                }
            }
        }


        private void Tsb_save_excel_Click(object sender, EventArgs e)
        {
            try
            {
                Microsoft.Office.Interop.Excel.Application excel = new Microsoft.Office.Interop.Excel.Application();
                excel.Visible = true;
                Microsoft.Office.Interop.Excel.Workbook workbook = excel.Workbooks.Add(System.Reflection.Missing.Value);
                Microsoft.Office.Interop.Excel.Worksheet sheet1 = (Microsoft.Office.Interop.Excel.Worksheet)workbook.Sheets[1];
                int StartCol = 1;
                int StartRow = 1;
                int j = 0, i = 0;

                for (j = 0; j < dgv_data_datakontainer.Columns.Count; j++)
                {
                    Microsoft.Office.Interop.Excel.Range myRange = (Microsoft.Office.Interop.Excel.Range)sheet1.Cells[StartRow, StartCol + j];
                    myRange.Value2 = dgv_data_datakontainer.Columns[j].HeaderText;
                }
                StartRow++;

                //Write datagridview content
                for (i = 0; i < dgv_data_datakontainer.Rows.Count; i++)
                {
                    for (j = 0; j < dgv_data_datakontainer.Columns.Count; j++)
                    {
                        try
                        {
                            Microsoft.Office.Interop.Excel.Range myRange = (Microsoft.Office.Interop.Excel.Range)sheet1.Cells[StartRow + i, StartCol + j];
                            myRange.Value2 = dgv_data_datakontainer[j, i].Value == null ? "" : dgv_data_datakontainer[j, i].Value;
                        }
                        catch (Exception err)
                        {
                            MessageBox.Show(err.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        }
                    }
                }
                MessageBox.Show("Data has been saved", "Data Exported", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            catch(Exception err)
            {
                MessageBox.Show(err.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

    }
}
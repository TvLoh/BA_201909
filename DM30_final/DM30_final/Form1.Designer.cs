namespace GUI_VD30
{
    partial class Form1
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.Windows.Forms.DataVisualization.Charting.ChartArea chartArea19 = new System.Windows.Forms.DataVisualization.Charting.ChartArea();
            System.Windows.Forms.DataVisualization.Charting.Legend legend19 = new System.Windows.Forms.DataVisualization.Charting.Legend();
            System.Windows.Forms.DataVisualization.Charting.Series series19 = new System.Windows.Forms.DataVisualization.Charting.Series();
            System.Windows.Forms.DataVisualization.Charting.ChartArea chartArea20 = new System.Windows.Forms.DataVisualization.Charting.ChartArea();
            System.Windows.Forms.DataVisualization.Charting.Legend legend20 = new System.Windows.Forms.DataVisualization.Charting.Legend();
            System.Windows.Forms.DataVisualization.Charting.Series series20 = new System.Windows.Forms.DataVisualization.Charting.Series();
            System.Windows.Forms.DataVisualization.Charting.ChartArea chartArea21 = new System.Windows.Forms.DataVisualization.Charting.ChartArea();
            System.Windows.Forms.DataVisualization.Charting.Legend legend21 = new System.Windows.Forms.DataVisualization.Charting.Legend();
            System.Windows.Forms.DataVisualization.Charting.Series series21 = new System.Windows.Forms.DataVisualization.Charting.Series();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.tabControl1 = new System.Windows.Forms.TabControl();
            this.tabPage1 = new System.Windows.Forms.TabPage();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.tableLayoutPanel2 = new System.Windows.Forms.TableLayoutPanel();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.lbl_data_out_length = new System.Windows.Forms.Label();
            this.lbl_data_in_length = new System.Windows.Forms.Label();
            this.cb_serial_data_dtr_enable = new System.Windows.Forms.CheckBox();
            this.cb_serial_data_rts_enable = new System.Windows.Forms.CheckBox();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.btn_serial_data_clear = new System.Windows.Forms.Button();
            this.btn_serial_data_send = new System.Windows.Forms.Button();
            this.tb_serial_data_receive = new System.Windows.Forms.TextBox();
            this.tb_serial_data_out = new System.Windows.Forms.TextBox();
            this.gb_com_controll = new System.Windows.Forms.GroupBox();
            this.pb_serial_data_status = new System.Windows.Forms.ProgressBar();
            this.btn_serial_data_close = new System.Windows.Forms.Button();
            this.btn_serial_data_open = new System.Windows.Forms.Button();
            this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
            this.cb_serial_data_com_port = new System.Windows.Forms.ComboBox();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.cb_serial_data_baudrate = new System.Windows.Forms.ComboBox();
            this.cb_serial_data_data_bits = new System.Windows.Forms.ComboBox();
            this.cb_serial_data_stop_bits = new System.Windows.Forms.ComboBox();
            this.cb_serial_data_parity_bits = new System.Windows.Forms.ComboBox();
            this.tabPage2 = new System.Windows.Forms.TabPage();
            this.dgv_data_datakontainer = new System.Windows.Forms.DataGridView();
            this.dg_col_time = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dg_col_hll_sens = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dg_col_load_cell_01 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dg_col_load_cell_02 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dg_col_Break_val = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dg_col_blade_01 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dg_col_blade_02 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dg_col_blade_03 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.groupBox4 = new System.Windows.Forms.GroupBox();
            this.tableLayoutPanel8 = new System.Windows.Forms.TableLayoutPanel();
            this.chart3 = new System.Windows.Forms.DataVisualization.Charting.Chart();
            this.chart2 = new System.Windows.Forms.DataVisualization.Charting.Chart();
            this.chart1 = new System.Windows.Forms.DataVisualization.Charting.Chart();
            this.toolStrip1 = new System.Windows.Forms.ToolStrip();
            this.tsb_save_txt = new System.Windows.Forms.ToolStripButton();
            this.tsb_save_excel = new System.Windows.Forms.ToolStripButton();
            this.tsb_help = new System.Windows.Forms.ToolStripButton();
            this.toolStripSeparator = new System.Windows.Forms.ToolStripSeparator();
            this.tsl_mause_y = new System.Windows.Forms.ToolStripLabel();
            this.toolStripSeparator1 = new System.Windows.Forms.ToolStripSeparator();
            this.tsl_zoomfactor = new System.Windows.Forms.ToolStripLabel();
            this.tsl_mause_x = new System.Windows.Forms.ToolStripLabel();
            this.tsl_timer = new System.Windows.Forms.ToolStripLabel();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.btn_control_send_blade_pos = new System.Windows.Forms.Button();
            this.tableLayoutPanel3 = new System.Windows.Forms.TableLayoutPanel();
            this.tbs_control_pos_brake = new System.Windows.Forms.TrackBar();
            this.tableLayoutPanel7 = new System.Windows.Forms.TableLayoutPanel();
            this.lbl_pos_brake = new System.Windows.Forms.Label();
            this.nud_control_pos_brake = new System.Windows.Forms.NumericUpDown();
            this.tbs_control_pos_blade_03 = new System.Windows.Forms.TrackBar();
            this.tableLayoutPanel6 = new System.Windows.Forms.TableLayoutPanel();
            this.lbl_pos_blade_03 = new System.Windows.Forms.Label();
            this.nud_control_pos_blade_03 = new System.Windows.Forms.NumericUpDown();
            this.tableLayoutPanel5 = new System.Windows.Forms.TableLayoutPanel();
            this.lbl_pos_blade_02 = new System.Windows.Forms.Label();
            this.nud_control_pos_blade_02 = new System.Windows.Forms.NumericUpDown();
            this.cb_controll_simultaeously = new System.Windows.Forms.CheckBox();
            this.tbs_control_pos_blade_01 = new System.Windows.Forms.TrackBar();
            this.label3 = new System.Windows.Forms.Label();
            this.tableLayoutPanel4 = new System.Windows.Forms.TableLayoutPanel();
            this.lbl_pos_blade_01 = new System.Windows.Forms.Label();
            this.nud_control_pos_blade_01 = new System.Windows.Forms.NumericUpDown();
            this.tbs_control_pos_blade_02 = new System.Windows.Forms.TrackBar();
            this.serialPort1 = new System.IO.Ports.SerialPort(this.components);
            this.timer_date = new System.Windows.Forms.Timer(this.components);
            this.timer_send_data = new System.Windows.Forms.Timer(this.components);
            this.tabControl1.SuspendLayout();
            this.tabPage1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.tableLayoutPanel2.SuspendLayout();
            this.groupBox1.SuspendLayout();
            this.gb_com_controll.SuspendLayout();
            this.tableLayoutPanel1.SuspendLayout();
            this.tabPage2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgv_data_datakontainer)).BeginInit();
            this.groupBox4.SuspendLayout();
            this.tableLayoutPanel8.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.chart3)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.chart2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.chart1)).BeginInit();
            this.toolStrip1.SuspendLayout();
            this.groupBox3.SuspendLayout();
            this.tableLayoutPanel3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.tbs_control_pos_brake)).BeginInit();
            this.tableLayoutPanel7.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.nud_control_pos_brake)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.tbs_control_pos_blade_03)).BeginInit();
            this.tableLayoutPanel6.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.nud_control_pos_blade_03)).BeginInit();
            this.tableLayoutPanel5.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.nud_control_pos_blade_02)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.tbs_control_pos_blade_01)).BeginInit();
            this.tableLayoutPanel4.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.nud_control_pos_blade_01)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.tbs_control_pos_blade_02)).BeginInit();
            this.SuspendLayout();
            // 
            // tabControl1
            // 
            this.tabControl1.Controls.Add(this.tabPage1);
            this.tabControl1.Controls.Add(this.tabPage2);
            this.tabControl1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tabControl1.Location = new System.Drawing.Point(0, 0);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(800, 451);
            this.tabControl1.TabIndex = 0;
            // 
            // tabPage1
            // 
            this.tabPage1.Controls.Add(this.groupBox2);
            this.tabPage1.Controls.Add(this.groupBox1);
            this.tabPage1.Controls.Add(this.gb_com_controll);
            this.tabPage1.Location = new System.Drawing.Point(4, 22);
            this.tabPage1.Name = "tabPage1";
            this.tabPage1.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage1.Size = new System.Drawing.Size(792, 425);
            this.tabPage1.TabIndex = 0;
            this.tabPage1.Text = "COM PORT - Settings";
            this.tabPage1.UseVisualStyleBackColor = true;
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.tableLayoutPanel2);
            this.groupBox2.Location = new System.Drawing.Point(3, 236);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(220, 69);
            this.groupBox2.TabIndex = 2;
            this.groupBox2.TabStop = false;
            // 
            // tableLayoutPanel2
            // 
            this.tableLayoutPanel2.ColumnCount = 3;
            this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 92F));
            this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 30F));
            this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 92F));
            this.tableLayoutPanel2.Controls.Add(this.label1, 0, 0);
            this.tableLayoutPanel2.Controls.Add(this.label2, 0, 1);
            this.tableLayoutPanel2.Controls.Add(this.lbl_data_out_length, 1, 0);
            this.tableLayoutPanel2.Controls.Add(this.lbl_data_in_length, 1, 1);
            this.tableLayoutPanel2.Controls.Add(this.cb_serial_data_dtr_enable, 2, 0);
            this.tableLayoutPanel2.Controls.Add(this.cb_serial_data_rts_enable, 2, 1);
            this.tableLayoutPanel2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel2.Location = new System.Drawing.Point(3, 16);
            this.tableLayoutPanel2.Margin = new System.Windows.Forms.Padding(0);
            this.tableLayoutPanel2.Name = "tableLayoutPanel2";
            this.tableLayoutPanel2.RowCount = 2;
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel2.Size = new System.Drawing.Size(214, 50);
            this.tableLayoutPanel2.TabIndex = 0;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Dock = System.Windows.Forms.DockStyle.Right;
            this.label1.Location = new System.Drawing.Point(3, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(86, 25);
            this.label1.TabIndex = 0;
            this.label1.Text = "Datat out length:";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Dock = System.Windows.Forms.DockStyle.Right;
            this.label2.Location = new System.Drawing.Point(13, 25);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(76, 25);
            this.label2.TabIndex = 1;
            this.label2.Text = "Data in length:";
            this.label2.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // lbl_data_out_length
            // 
            this.lbl_data_out_length.AutoSize = true;
            this.lbl_data_out_length.Dock = System.Windows.Forms.DockStyle.Fill;
            this.lbl_data_out_length.Location = new System.Drawing.Point(95, 0);
            this.lbl_data_out_length.Name = "lbl_data_out_length";
            this.lbl_data_out_length.Size = new System.Drawing.Size(24, 25);
            this.lbl_data_out_length.TabIndex = 2;
            this.lbl_data_out_length.Text = "00";
            this.lbl_data_out_length.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // lbl_data_in_length
            // 
            this.lbl_data_in_length.AutoSize = true;
            this.lbl_data_in_length.Dock = System.Windows.Forms.DockStyle.Fill;
            this.lbl_data_in_length.Location = new System.Drawing.Point(95, 25);
            this.lbl_data_in_length.Name = "lbl_data_in_length";
            this.lbl_data_in_length.Size = new System.Drawing.Size(24, 25);
            this.lbl_data_in_length.TabIndex = 3;
            this.lbl_data_in_length.Text = "00";
            this.lbl_data_in_length.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // cb_serial_data_dtr_enable
            // 
            this.cb_serial_data_dtr_enable.AutoSize = true;
            this.cb_serial_data_dtr_enable.Dock = System.Windows.Forms.DockStyle.Right;
            this.cb_serial_data_dtr_enable.Location = new System.Drawing.Point(126, 3);
            this.cb_serial_data_dtr_enable.Name = "cb_serial_data_dtr_enable";
            this.cb_serial_data_dtr_enable.Size = new System.Drawing.Size(85, 19);
            this.cb_serial_data_dtr_enable.TabIndex = 4;
            this.cb_serial_data_dtr_enable.Text = "DTR Enable";
            this.cb_serial_data_dtr_enable.UseVisualStyleBackColor = true;
            this.cb_serial_data_dtr_enable.CheckedChanged += new System.EventHandler(this.Cb_serial_data_dtr_enable_CheckedChanged);
            // 
            // cb_serial_data_rts_enable
            // 
            this.cb_serial_data_rts_enable.AutoSize = true;
            this.cb_serial_data_rts_enable.Dock = System.Windows.Forms.DockStyle.Right;
            this.cb_serial_data_rts_enable.Location = new System.Drawing.Point(127, 28);
            this.cb_serial_data_rts_enable.Name = "cb_serial_data_rts_enable";
            this.cb_serial_data_rts_enable.Size = new System.Drawing.Size(84, 19);
            this.cb_serial_data_rts_enable.TabIndex = 5;
            this.cb_serial_data_rts_enable.Text = "RTS Enable";
            this.cb_serial_data_rts_enable.UseVisualStyleBackColor = true;
            this.cb_serial_data_rts_enable.CheckedChanged += new System.EventHandler(this.Cb_serial_data_rts_enable_CheckedChanged);
            // 
            // groupBox1
            // 
            this.groupBox1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.groupBox1.Controls.Add(this.btn_serial_data_clear);
            this.groupBox1.Controls.Add(this.btn_serial_data_send);
            this.groupBox1.Controls.Add(this.tb_serial_data_receive);
            this.groupBox1.Controls.Add(this.tb_serial_data_out);
            this.groupBox1.Location = new System.Drawing.Point(226, 3);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(563, 419);
            this.groupBox1.TabIndex = 1;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Monitor";
            // 
            // btn_serial_data_clear
            // 
            this.btn_serial_data_clear.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.btn_serial_data_clear.Enabled = false;
            this.btn_serial_data_clear.Location = new System.Drawing.Point(6, 390);
            this.btn_serial_data_clear.Name = "btn_serial_data_clear";
            this.btn_serial_data_clear.Size = new System.Drawing.Size(551, 23);
            this.btn_serial_data_clear.TabIndex = 4;
            this.btn_serial_data_clear.Text = "Claer Data";
            this.btn_serial_data_clear.UseVisualStyleBackColor = true;
            this.btn_serial_data_clear.Click += new System.EventHandler(this.Btn_serial_data_clear_Click);
            // 
            // btn_serial_data_send
            // 
            this.btn_serial_data_send.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btn_serial_data_send.Enabled = false;
            this.btn_serial_data_send.Location = new System.Drawing.Point(485, 17);
            this.btn_serial_data_send.Name = "btn_serial_data_send";
            this.btn_serial_data_send.Size = new System.Drawing.Size(75, 23);
            this.btn_serial_data_send.TabIndex = 3;
            this.btn_serial_data_send.Text = "Send";
            this.btn_serial_data_send.UseVisualStyleBackColor = true;
            this.btn_serial_data_send.Click += new System.EventHandler(this.Btn_serial_data_send_Click);
            // 
            // tb_serial_data_receive
            // 
            this.tb_serial_data_receive.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.tb_serial_data_receive.BackColor = System.Drawing.SystemColors.Menu;
            this.tb_serial_data_receive.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.tb_serial_data_receive.Location = new System.Drawing.Point(6, 43);
            this.tb_serial_data_receive.Multiline = true;
            this.tb_serial_data_receive.Name = "tb_serial_data_receive";
            this.tb_serial_data_receive.ReadOnly = true;
            this.tb_serial_data_receive.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.tb_serial_data_receive.Size = new System.Drawing.Size(551, 345);
            this.tb_serial_data_receive.TabIndex = 1;
            this.tb_serial_data_receive.TextChanged += new System.EventHandler(this.Tb_serial_data_receive_TextChanged);
            // 
            // tb_serial_data_out
            // 
            this.tb_serial_data_out.AllowDrop = true;
            this.tb_serial_data_out.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.tb_serial_data_out.Enabled = false;
            this.tb_serial_data_out.Location = new System.Drawing.Point(6, 19);
            this.tb_serial_data_out.Name = "tb_serial_data_out";
            this.tb_serial_data_out.Size = new System.Drawing.Size(488, 20);
            this.tb_serial_data_out.TabIndex = 0;
            this.tb_serial_data_out.TextChanged += new System.EventHandler(this.Tb_serial_data_out_TextChanged);
            this.tb_serial_data_out.KeyDown += new System.Windows.Forms.KeyEventHandler(this.Tb_serial_data_out_KeyDown);
            // 
            // gb_com_controll
            // 
            this.gb_com_controll.Controls.Add(this.pb_serial_data_status);
            this.gb_com_controll.Controls.Add(this.btn_serial_data_close);
            this.gb_com_controll.Controls.Add(this.btn_serial_data_open);
            this.gb_com_controll.Controls.Add(this.tableLayoutPanel1);
            this.gb_com_controll.Location = new System.Drawing.Point(3, 3);
            this.gb_com_controll.MaximumSize = new System.Drawing.Size(220, 418);
            this.gb_com_controll.Name = "gb_com_controll";
            this.gb_com_controll.Size = new System.Drawing.Size(220, 233);
            this.gb_com_controll.TabIndex = 0;
            this.gb_com_controll.TabStop = false;
            this.gb_com_controll.Text = "COM Port control";
            // 
            // pb_serial_data_status
            // 
            this.pb_serial_data_status.Location = new System.Drawing.Point(9, 202);
            this.pb_serial_data_status.Name = "pb_serial_data_status";
            this.pb_serial_data_status.Size = new System.Drawing.Size(205, 23);
            this.pb_serial_data_status.TabIndex = 3;
            // 
            // btn_serial_data_close
            // 
            this.btn_serial_data_close.Enabled = false;
            this.btn_serial_data_close.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_serial_data_close.Location = new System.Drawing.Point(114, 163);
            this.btn_serial_data_close.Name = "btn_serial_data_close";
            this.btn_serial_data_close.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.btn_serial_data_close.Size = new System.Drawing.Size(100, 33);
            this.btn_serial_data_close.TabIndex = 2;
            this.btn_serial_data_close.Text = "Close";
            this.btn_serial_data_close.UseVisualStyleBackColor = true;
            this.btn_serial_data_close.Click += new System.EventHandler(this.Btn_serial_data_close_Click);
            // 
            // btn_serial_data_open
            // 
            this.btn_serial_data_open.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_serial_data_open.Location = new System.Drawing.Point(9, 163);
            this.btn_serial_data_open.Name = "btn_serial_data_open";
            this.btn_serial_data_open.Size = new System.Drawing.Size(100, 33);
            this.btn_serial_data_open.TabIndex = 1;
            this.btn_serial_data_open.Text = "Open";
            this.btn_serial_data_open.UseVisualStyleBackColor = true;
            this.btn_serial_data_open.Click += new System.EventHandler(this.Btn_serial_data_open_Click);
            // 
            // tableLayoutPanel1
            // 
            this.tableLayoutPanel1.ColumnCount = 2;
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 42.05608F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 57.94392F));
            this.tableLayoutPanel1.Controls.Add(this.cb_serial_data_com_port, 1, 0);
            this.tableLayoutPanel1.Controls.Add(this.label4, 0, 0);
            this.tableLayoutPanel1.Controls.Add(this.label5, 0, 1);
            this.tableLayoutPanel1.Controls.Add(this.label6, 0, 2);
            this.tableLayoutPanel1.Controls.Add(this.label7, 0, 3);
            this.tableLayoutPanel1.Controls.Add(this.label8, 0, 4);
            this.tableLayoutPanel1.Controls.Add(this.cb_serial_data_baudrate, 1, 1);
            this.tableLayoutPanel1.Controls.Add(this.cb_serial_data_data_bits, 1, 2);
            this.tableLayoutPanel1.Controls.Add(this.cb_serial_data_stop_bits, 1, 3);
            this.tableLayoutPanel1.Controls.Add(this.cb_serial_data_parity_bits, 1, 4);
            this.tableLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.tableLayoutPanel1.Location = new System.Drawing.Point(3, 16);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.RowCount = 5;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 20F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 20F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 20F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 20F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 20F));
            this.tableLayoutPanel1.Size = new System.Drawing.Size(214, 139);
            this.tableLayoutPanel1.TabIndex = 0;
            // 
            // cb_serial_data_com_port
            // 
            this.cb_serial_data_com_port.Dock = System.Windows.Forms.DockStyle.Fill;
            this.cb_serial_data_com_port.FormattingEnabled = true;
            this.cb_serial_data_com_port.Location = new System.Drawing.Point(93, 3);
            this.cb_serial_data_com_port.Name = "cb_serial_data_com_port";
            this.cb_serial_data_com_port.Size = new System.Drawing.Size(118, 21);
            this.cb_serial_data_com_port.TabIndex = 0;
            this.cb_serial_data_com_port.Text = "choose";
            this.cb_serial_data_com_port.DropDown += new System.EventHandler(this.Cb_serial_data_com_port_DropDown);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Dock = System.Windows.Forms.DockStyle.Fill;
            this.label4.Location = new System.Drawing.Point(3, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(84, 27);
            this.label4.TabIndex = 0;
            this.label4.Text = "COM PORT";
            this.label4.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Dock = System.Windows.Forms.DockStyle.Fill;
            this.label5.Location = new System.Drawing.Point(3, 27);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(84, 27);
            this.label5.TabIndex = 1;
            this.label5.Text = "BAUD RATE";
            this.label5.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Dock = System.Windows.Forms.DockStyle.Fill;
            this.label6.Location = new System.Drawing.Point(3, 54);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(84, 27);
            this.label6.TabIndex = 2;
            this.label6.Text = "DATA BITS";
            this.label6.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Dock = System.Windows.Forms.DockStyle.Fill;
            this.label7.Location = new System.Drawing.Point(3, 81);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(84, 27);
            this.label7.TabIndex = 3;
            this.label7.Text = "STOP BITS";
            this.label7.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Dock = System.Windows.Forms.DockStyle.Fill;
            this.label8.Location = new System.Drawing.Point(3, 108);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(84, 31);
            this.label8.TabIndex = 4;
            this.label8.Text = "PARITY BITS";
            this.label8.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // cb_serial_data_baudrate
            // 
            this.cb_serial_data_baudrate.FormattingEnabled = true;
            this.cb_serial_data_baudrate.Items.AddRange(new object[] {
            "300",
            "1200",
            "2400",
            "4800",
            "9600",
            "19200",
            "38400",
            "57600",
            "74880",
            "115200",
            "230400",
            "250000",
            "500000",
            "1000000",
            "2000000"});
            this.cb_serial_data_baudrate.Location = new System.Drawing.Point(93, 30);
            this.cb_serial_data_baudrate.Name = "cb_serial_data_baudrate";
            this.cb_serial_data_baudrate.Size = new System.Drawing.Size(118, 21);
            this.cb_serial_data_baudrate.TabIndex = 5;
            this.cb_serial_data_baudrate.Text = "115200";
            // 
            // cb_serial_data_data_bits
            // 
            this.cb_serial_data_data_bits.FormattingEnabled = true;
            this.cb_serial_data_data_bits.Items.AddRange(new object[] {
            "6",
            "7",
            "8"});
            this.cb_serial_data_data_bits.Location = new System.Drawing.Point(93, 57);
            this.cb_serial_data_data_bits.Name = "cb_serial_data_data_bits";
            this.cb_serial_data_data_bits.Size = new System.Drawing.Size(118, 21);
            this.cb_serial_data_data_bits.TabIndex = 6;
            this.cb_serial_data_data_bits.Text = "8";
            // 
            // cb_serial_data_stop_bits
            // 
            this.cb_serial_data_stop_bits.FormattingEnabled = true;
            this.cb_serial_data_stop_bits.Items.AddRange(new object[] {
            "One",
            "Two"});
            this.cb_serial_data_stop_bits.Location = new System.Drawing.Point(93, 84);
            this.cb_serial_data_stop_bits.Name = "cb_serial_data_stop_bits";
            this.cb_serial_data_stop_bits.Size = new System.Drawing.Size(118, 21);
            this.cb_serial_data_stop_bits.TabIndex = 7;
            this.cb_serial_data_stop_bits.Text = "One";
            // 
            // cb_serial_data_parity_bits
            // 
            this.cb_serial_data_parity_bits.FormattingEnabled = true;
            this.cb_serial_data_parity_bits.Items.AddRange(new object[] {
            "None",
            "Odd",
            "Even"});
            this.cb_serial_data_parity_bits.Location = new System.Drawing.Point(93, 111);
            this.cb_serial_data_parity_bits.Name = "cb_serial_data_parity_bits";
            this.cb_serial_data_parity_bits.Size = new System.Drawing.Size(118, 21);
            this.cb_serial_data_parity_bits.TabIndex = 8;
            this.cb_serial_data_parity_bits.Text = "None";
            // 
            // tabPage2
            // 
            this.tabPage2.Controls.Add(this.dgv_data_datakontainer);
            this.tabPage2.Controls.Add(this.groupBox4);
            this.tabPage2.Controls.Add(this.groupBox3);
            this.tabPage2.Location = new System.Drawing.Point(4, 22);
            this.tabPage2.Name = "tabPage2";
            this.tabPage2.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage2.Size = new System.Drawing.Size(792, 425);
            this.tabPage2.TabIndex = 1;
            this.tabPage2.Text = "VD30 - Control Center";
            this.tabPage2.UseVisualStyleBackColor = true;
            // 
            // dgv_data_datakontainer
            // 
            this.dgv_data_datakontainer.AllowUserToDeleteRows = false;
            this.dgv_data_datakontainer.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgv_data_datakontainer.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.dg_col_time,
            this.dg_col_hll_sens,
            this.dg_col_load_cell_01,
            this.dg_col_load_cell_02,
            this.dg_col_Break_val,
            this.dg_col_blade_01,
            this.dg_col_blade_02,
            this.dg_col_blade_03});
            this.dgv_data_datakontainer.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.dgv_data_datakontainer.Location = new System.Drawing.Point(3, 328);
            this.dgv_data_datakontainer.Name = "dgv_data_datakontainer";
            this.dgv_data_datakontainer.Size = new System.Drawing.Size(786, 94);
            this.dgv_data_datakontainer.TabIndex = 2;
            // 
            // dg_col_time
            // 
            this.dg_col_time.HeaderText = "Time";
            this.dg_col_time.MaxInputLength = 20;
            this.dg_col_time.Name = "dg_col_time";
            this.dg_col_time.ReadOnly = true;
            // 
            // dg_col_hll_sens
            // 
            this.dg_col_hll_sens.HeaderText = "Hall Sens";
            this.dg_col_hll_sens.MaxInputLength = 20;
            this.dg_col_hll_sens.Name = "dg_col_hll_sens";
            this.dg_col_hll_sens.ReadOnly = true;
            // 
            // dg_col_load_cell_01
            // 
            this.dg_col_load_cell_01.HeaderText = "Load Cell 1";
            this.dg_col_load_cell_01.MaxInputLength = 20;
            this.dg_col_load_cell_01.Name = "dg_col_load_cell_01";
            this.dg_col_load_cell_01.ReadOnly = true;
            // 
            // dg_col_load_cell_02
            // 
            this.dg_col_load_cell_02.HeaderText = "Load Cell 2";
            this.dg_col_load_cell_02.MaxInputLength = 20;
            this.dg_col_load_cell_02.Name = "dg_col_load_cell_02";
            this.dg_col_load_cell_02.ReadOnly = true;
            // 
            // dg_col_Break_val
            // 
            this.dg_col_Break_val.HeaderText = "Break val.";
            this.dg_col_Break_val.MaxInputLength = 20;
            this.dg_col_Break_val.Name = "dg_col_Break_val";
            this.dg_col_Break_val.ReadOnly = true;
            // 
            // dg_col_blade_01
            // 
            this.dg_col_blade_01.HeaderText = "Blade 1";
            this.dg_col_blade_01.MaxInputLength = 20;
            this.dg_col_blade_01.Name = "dg_col_blade_01";
            this.dg_col_blade_01.ReadOnly = true;
            // 
            // dg_col_blade_02
            // 
            this.dg_col_blade_02.HeaderText = "Blade 2";
            this.dg_col_blade_02.MaxInputLength = 20;
            this.dg_col_blade_02.Name = "dg_col_blade_02";
            this.dg_col_blade_02.ReadOnly = true;
            // 
            // dg_col_blade_03
            // 
            this.dg_col_blade_03.HeaderText = "Blade 3";
            this.dg_col_blade_03.MaxInputLength = 20;
            this.dg_col_blade_03.Name = "dg_col_blade_03";
            this.dg_col_blade_03.ReadOnly = true;
            // 
            // groupBox4
            // 
            this.groupBox4.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.groupBox4.BackColor = System.Drawing.Color.Gainsboro;
            this.groupBox4.Controls.Add(this.tableLayoutPanel8);
            this.groupBox4.Controls.Add(this.toolStrip1);
            this.groupBox4.Location = new System.Drawing.Point(226, 3);
            this.groupBox4.Name = "groupBox4";
            this.groupBox4.Size = new System.Drawing.Size(563, 319);
            this.groupBox4.TabIndex = 1;
            this.groupBox4.TabStop = false;
            this.groupBox4.Text = "Monitor";
            // 
            // tableLayoutPanel8
            // 
            this.tableLayoutPanel8.ColumnCount = 1;
            this.tableLayoutPanel8.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel8.Controls.Add(this.chart3, 0, 2);
            this.tableLayoutPanel8.Controls.Add(this.chart2, 0, 1);
            this.tableLayoutPanel8.Controls.Add(this.chart1, 0, 0);
            this.tableLayoutPanel8.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel8.Location = new System.Drawing.Point(3, 16);
            this.tableLayoutPanel8.Name = "tableLayoutPanel8";
            this.tableLayoutPanel8.RowCount = 3;
            this.tableLayoutPanel8.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 33.33333F));
            this.tableLayoutPanel8.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 33.33333F));
            this.tableLayoutPanel8.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 33.33333F));
            this.tableLayoutPanel8.Size = new System.Drawing.Size(557, 268);
            this.tableLayoutPanel8.TabIndex = 1;
            // 
            // chart3
            // 
            this.chart3.BackColor = System.Drawing.Color.Gainsboro;
            chartArea19.AxisX.MajorGrid.Enabled = false;
            chartArea19.AxisY.MajorGrid.LineColor = System.Drawing.Color.Gainsboro;
            chartArea19.Name = "ChartArea1";
            this.chart3.ChartAreas.Add(chartArea19);
            this.chart3.Cursor = System.Windows.Forms.Cursors.Cross;
            this.chart3.Dock = System.Windows.Forms.DockStyle.Fill;
            legend19.DockedToChartArea = "ChartArea1";
            legend19.Docking = System.Windows.Forms.DataVisualization.Charting.Docking.Left;
            legend19.MaximumAutoSize = 20F;
            legend19.Name = "Legend1";
            this.chart3.Legends.Add(legend19);
            this.chart3.Location = new System.Drawing.Point(0, 179);
            this.chart3.Margin = new System.Windows.Forms.Padding(0, 1, 0, 1);
            this.chart3.Name = "chart3";
            series19.ChartArea = "ChartArea1";
            series19.ChartType = System.Windows.Forms.DataVisualization.Charting.SeriesChartType.Line;
            series19.Color = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
            series19.IsXValueIndexed = true;
            series19.Legend = "Legend1";
            series19.Name = "Series1";
            this.chart3.Series.Add(series19);
            this.chart3.Size = new System.Drawing.Size(557, 88);
            this.chart3.TabIndex = 2;
            this.chart3.Text = "chart3";
            this.chart3.MouseMove += new System.Windows.Forms.MouseEventHandler(this.Chart3_MouseMove);
            // 
            // chart2
            // 
            this.chart2.BackColor = System.Drawing.Color.Gainsboro;
            chartArea20.AxisX.MajorGrid.Enabled = false;
            chartArea20.AxisY.MajorGrid.LineColor = System.Drawing.Color.Gainsboro;
            chartArea20.Name = "ChartArea1";
            this.chart2.ChartAreas.Add(chartArea20);
            this.chart2.Cursor = System.Windows.Forms.Cursors.Cross;
            this.chart2.Dock = System.Windows.Forms.DockStyle.Fill;
            legend20.DockedToChartArea = "ChartArea1";
            legend20.Docking = System.Windows.Forms.DataVisualization.Charting.Docking.Left;
            legend20.MaximumAutoSize = 20F;
            legend20.Name = "Legend1";
            this.chart2.Legends.Add(legend20);
            this.chart2.Location = new System.Drawing.Point(0, 90);
            this.chart2.Margin = new System.Windows.Forms.Padding(0, 1, 0, 1);
            this.chart2.Name = "chart2";
            series20.BackSecondaryColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            series20.ChartArea = "ChartArea1";
            series20.ChartType = System.Windows.Forms.DataVisualization.Charting.SeriesChartType.Line;
            series20.Color = System.Drawing.Color.Red;
            series20.IsXValueIndexed = true;
            series20.LabelBackColor = System.Drawing.Color.White;
            series20.Legend = "Legend1";
            series20.MarkerColor = System.Drawing.Color.White;
            series20.Name = "Series1";
            this.chart2.Series.Add(series20);
            this.chart2.Size = new System.Drawing.Size(557, 87);
            this.chart2.TabIndex = 1;
            this.chart2.Text = "chart2";
            this.chart2.MouseMove += new System.Windows.Forms.MouseEventHandler(this.Chart2_MouseMove);
            // 
            // chart1
            // 
            this.chart1.BackColor = System.Drawing.Color.Gainsboro;
            this.chart1.BorderlineColor = System.Drawing.Color.Empty;
            chartArea21.AxisX.MajorGrid.Enabled = false;
            chartArea21.AxisX.MajorGrid.LineColor = System.Drawing.Color.Gainsboro;
            chartArea21.AxisX.MajorTickMark.LineColor = System.Drawing.Color.Empty;
            chartArea21.AxisY.MajorGrid.LineColor = System.Drawing.Color.Gainsboro;
            chartArea21.Name = "ChartArea1";
            this.chart1.ChartAreas.Add(chartArea21);
            this.chart1.Cursor = System.Windows.Forms.Cursors.Cross;
            this.chart1.Dock = System.Windows.Forms.DockStyle.Fill;
            legend21.DockedToChartArea = "ChartArea1";
            legend21.Docking = System.Windows.Forms.DataVisualization.Charting.Docking.Left;
            legend21.MaximumAutoSize = 30F;
            legend21.Name = "Legend1";
            this.chart1.Legends.Add(legend21);
            this.chart1.Location = new System.Drawing.Point(0, 1);
            this.chart1.Margin = new System.Windows.Forms.Padding(0, 1, 0, 1);
            this.chart1.Name = "chart1";
            series21.ChartArea = "ChartArea1";
            series21.ChartType = System.Windows.Forms.DataVisualization.Charting.SeriesChartType.Line;
            series21.IsXValueIndexed = true;
            series21.Legend = "Legend1";
            series21.Name = "Series1";
            this.chart1.Series.Add(series21);
            this.chart1.Size = new System.Drawing.Size(557, 87);
            this.chart1.TabIndex = 0;
            this.chart1.Text = "chart1";
            this.chart1.MouseMove += new System.Windows.Forms.MouseEventHandler(this.Data_chart1_MouseMove);
            // 
            // toolStrip1
            // 
            this.toolStrip1.BackColor = System.Drawing.Color.Gainsboro;
            this.toolStrip1.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.toolStrip1.ImageScalingSize = new System.Drawing.Size(25, 25);
            this.toolStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.tsb_save_txt,
            this.tsb_save_excel,
            this.tsb_help,
            this.toolStripSeparator,
            this.tsl_mause_y,
            this.toolStripSeparator1,
            this.tsl_zoomfactor,
            this.tsl_mause_x,
            this.tsl_timer});
            this.toolStrip1.Location = new System.Drawing.Point(3, 284);
            this.toolStrip1.Name = "toolStrip1";
            this.toolStrip1.RenderMode = System.Windows.Forms.ToolStripRenderMode.System;
            this.toolStrip1.Size = new System.Drawing.Size(557, 32);
            this.toolStrip1.TabIndex = 0;
            this.toolStrip1.Text = "toolStrip1";
            // 
            // tsb_save_txt
            // 
            this.tsb_save_txt.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.tsb_save_txt.Image = ((System.Drawing.Image)(resources.GetObject("tsb_save_txt.Image")));
            this.tsb_save_txt.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.tsb_save_txt.Name = "tsb_save_txt";
            this.tsb_save_txt.Size = new System.Drawing.Size(29, 29);
            this.tsb_save_txt.Text = "toolStripButton1";
            this.tsb_save_txt.ToolTipText = "Save Data as .txt";
            this.tsb_save_txt.Click += new System.EventHandler(this.Tsb_save_txt_Click);
            // 
            // tsb_save_excel
            // 
            this.tsb_save_excel.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.tsb_save_excel.Font = new System.Drawing.Font("Segoe UI", 12F);
            this.tsb_save_excel.Image = ((System.Drawing.Image)(resources.GetObject("tsb_save_excel.Image")));
            this.tsb_save_excel.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.tsb_save_excel.Name = "tsb_save_excel";
            this.tsb_save_excel.Size = new System.Drawing.Size(29, 29);
            this.tsb_save_excel.Text = "toolStripButton2";
            this.tsb_save_excel.ToolTipText = "Save Data as .xlsx";
            this.tsb_save_excel.Click += new System.EventHandler(this.Tsb_save_excel_Click);
            // 
            // tsb_help
            // 
            this.tsb_help.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.tsb_help.Image = ((System.Drawing.Image)(resources.GetObject("tsb_help.Image")));
            this.tsb_help.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.tsb_help.Name = "tsb_help";
            this.tsb_help.Size = new System.Drawing.Size(29, 29);
            this.tsb_help.Text = "He&lp";
            // 
            // toolStripSeparator
            // 
            this.toolStripSeparator.Name = "toolStripSeparator";
            this.toolStripSeparator.Size = new System.Drawing.Size(6, 32);
            // 
            // tsl_mause_y
            // 
            this.tsl_mause_y.Name = "tsl_mause_y";
            this.tsl_mause_y.Size = new System.Drawing.Size(84, 29);
            this.tsl_mause_y.Text = "Mouse Pos. Y: ";
            this.tsl_mause_y.ToolTipText = "Y - value of Mouse Pos.";
            // 
            // toolStripSeparator1
            // 
            this.toolStripSeparator1.Name = "toolStripSeparator1";
            this.toolStripSeparator1.Size = new System.Drawing.Size(6, 32);
            // 
            // tsl_zoomfactor
            // 
            this.tsl_zoomfactor.Name = "tsl_zoomfactor";
            this.tsl_zoomfactor.Size = new System.Drawing.Size(94, 29);
            this.tsl_zoomfactor.Text = " Zoom X-Axis: --";
            this.tsl_zoomfactor.ToolTipText = "current zoom factor";
            // 
            // tsl_mause_x
            // 
            this.tsl_mause_x.ForeColor = System.Drawing.SystemColors.ControlLight;
            this.tsl_mause_x.Name = "tsl_mause_x";
            this.tsl_mause_x.Size = new System.Drawing.Size(22, 29);
            this.tsl_mause_x.Text = "---";
            this.tsl_mause_x.ToolTipText = "x - value of Mouse Pos.";
            // 
            // tsl_timer
            // 
            this.tsl_timer.ForeColor = System.Drawing.Color.Gainsboro;
            this.tsl_timer.Name = "tsl_timer";
            this.tsl_timer.Size = new System.Drawing.Size(86, 29);
            this.tsl_timer.Text = "toolStripLabel1";
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.btn_control_send_blade_pos);
            this.groupBox3.Controls.Add(this.tableLayoutPanel3);
            this.groupBox3.Location = new System.Drawing.Point(3, 3);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(220, 318);
            this.groupBox3.TabIndex = 0;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "Control Bar";
            // 
            // btn_control_send_blade_pos
            // 
            this.btn_control_send_blade_pos.Location = new System.Drawing.Point(3, 269);
            this.btn_control_send_blade_pos.Name = "btn_control_send_blade_pos";
            this.btn_control_send_blade_pos.Size = new System.Drawing.Size(214, 43);
            this.btn_control_send_blade_pos.TabIndex = 1;
            this.btn_control_send_blade_pos.Text = "Send Blade Pos.";
            this.btn_control_send_blade_pos.UseVisualStyleBackColor = true;
            this.btn_control_send_blade_pos.Click += new System.EventHandler(this.Btn_control_send_blade_pos_Click);
            // 
            // tableLayoutPanel3
            // 
            this.tableLayoutPanel3.ColumnCount = 1;
            this.tableLayoutPanel3.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel3.Controls.Add(this.tbs_control_pos_brake, 0, 9);
            this.tableLayoutPanel3.Controls.Add(this.tableLayoutPanel7, 0, 8);
            this.tableLayoutPanel3.Controls.Add(this.tbs_control_pos_blade_03, 0, 7);
            this.tableLayoutPanel3.Controls.Add(this.tableLayoutPanel6, 0, 6);
            this.tableLayoutPanel3.Controls.Add(this.tableLayoutPanel5, 0, 4);
            this.tableLayoutPanel3.Controls.Add(this.cb_controll_simultaeously, 0, 0);
            this.tableLayoutPanel3.Controls.Add(this.tbs_control_pos_blade_01, 0, 3);
            this.tableLayoutPanel3.Controls.Add(this.label3, 0, 1);
            this.tableLayoutPanel3.Controls.Add(this.tableLayoutPanel4, 0, 2);
            this.tableLayoutPanel3.Controls.Add(this.tbs_control_pos_blade_02, 0, 5);
            this.tableLayoutPanel3.Dock = System.Windows.Forms.DockStyle.Top;
            this.tableLayoutPanel3.Location = new System.Drawing.Point(3, 16);
            this.tableLayoutPanel3.Name = "tableLayoutPanel3";
            this.tableLayoutPanel3.RowCount = 11;
            this.tableLayoutPanel3.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 25F));
            this.tableLayoutPanel3.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 25F));
            this.tableLayoutPanel3.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 25F));
            this.tableLayoutPanel3.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 25F));
            this.tableLayoutPanel3.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 25F));
            this.tableLayoutPanel3.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 25F));
            this.tableLayoutPanel3.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 25F));
            this.tableLayoutPanel3.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 25F));
            this.tableLayoutPanel3.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 25F));
            this.tableLayoutPanel3.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 25F));
            this.tableLayoutPanel3.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.tableLayoutPanel3.Size = new System.Drawing.Size(214, 253);
            this.tableLayoutPanel3.TabIndex = 0;
            // 
            // tbs_control_pos_brake
            // 
            this.tbs_control_pos_brake.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tbs_control_pos_brake.Location = new System.Drawing.Point(3, 226);
            this.tbs_control_pos_brake.Margin = new System.Windows.Forms.Padding(3, 1, 3, 8);
            this.tbs_control_pos_brake.Maximum = 180;
            this.tbs_control_pos_brake.Name = "tbs_control_pos_brake";
            this.tbs_control_pos_brake.Size = new System.Drawing.Size(208, 16);
            this.tbs_control_pos_brake.TabIndex = 8;
            this.tbs_control_pos_brake.Scroll += new System.EventHandler(this.Tb_control_pos_brake_Scroll);
            // 
            // tableLayoutPanel7
            // 
            this.tableLayoutPanel7.ColumnCount = 2;
            this.tableLayoutPanel7.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 39.71963F));
            this.tableLayoutPanel7.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 60.28037F));
            this.tableLayoutPanel7.Controls.Add(this.lbl_pos_brake, 0, 0);
            this.tableLayoutPanel7.Controls.Add(this.nud_control_pos_brake, 1, 0);
            this.tableLayoutPanel7.Dock = System.Windows.Forms.DockStyle.Top;
            this.tableLayoutPanel7.Location = new System.Drawing.Point(0, 200);
            this.tableLayoutPanel7.Margin = new System.Windows.Forms.Padding(0);
            this.tableLayoutPanel7.Name = "tableLayoutPanel7";
            this.tableLayoutPanel7.RowCount = 1;
            this.tableLayoutPanel7.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel7.Size = new System.Drawing.Size(214, 20);
            this.tableLayoutPanel7.TabIndex = 7;
            // 
            // lbl_pos_brake
            // 
            this.lbl_pos_brake.AutoSize = true;
            this.lbl_pos_brake.Dock = System.Windows.Forms.DockStyle.Right;
            this.lbl_pos_brake.Location = new System.Drawing.Point(20, 0);
            this.lbl_pos_brake.Name = "lbl_pos_brake";
            this.lbl_pos_brake.Size = new System.Drawing.Size(62, 20);
            this.lbl_pos_brake.TabIndex = 0;
            this.lbl_pos_brake.Text = "Pos. Brake:";
            this.lbl_pos_brake.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // nud_control_pos_brake
            // 
            this.nud_control_pos_brake.Dock = System.Windows.Forms.DockStyle.Fill;
            this.nud_control_pos_brake.Location = new System.Drawing.Point(88, 3);
            this.nud_control_pos_brake.Maximum = new decimal(new int[] {
            180,
            0,
            0,
            0});
            this.nud_control_pos_brake.Name = "nud_control_pos_brake";
            this.nud_control_pos_brake.Size = new System.Drawing.Size(123, 20);
            this.nud_control_pos_brake.TabIndex = 1;
            this.nud_control_pos_brake.ValueChanged += new System.EventHandler(this.Nud_control_pos_brake_ValueChanged_1);
            this.nud_control_pos_brake.Scroll += new System.Windows.Forms.ScrollEventHandler(this.Nud_control_pos_brake_Scroll);
            // 
            // tbs_control_pos_blade_03
            // 
            this.tbs_control_pos_blade_03.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tbs_control_pos_blade_03.Enabled = false;
            this.tbs_control_pos_blade_03.Location = new System.Drawing.Point(3, 176);
            this.tbs_control_pos_blade_03.Margin = new System.Windows.Forms.Padding(3, 1, 3, 8);
            this.tbs_control_pos_blade_03.Maximum = 180;
            this.tbs_control_pos_blade_03.Name = "tbs_control_pos_blade_03";
            this.tbs_control_pos_blade_03.Size = new System.Drawing.Size(208, 16);
            this.tbs_control_pos_blade_03.TabIndex = 6;
            this.tbs_control_pos_blade_03.Value = 80;
            this.tbs_control_pos_blade_03.Scroll += new System.EventHandler(this.Tbs_control_pos_blade_03_Scroll);
            // 
            // tableLayoutPanel6
            // 
            this.tableLayoutPanel6.ColumnCount = 2;
            this.tableLayoutPanel6.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 39.71963F));
            this.tableLayoutPanel6.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 60.28037F));
            this.tableLayoutPanel6.Controls.Add(this.lbl_pos_blade_03, 0, 0);
            this.tableLayoutPanel6.Controls.Add(this.nud_control_pos_blade_03, 1, 0);
            this.tableLayoutPanel6.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel6.Location = new System.Drawing.Point(0, 150);
            this.tableLayoutPanel6.Margin = new System.Windows.Forms.Padding(0);
            this.tableLayoutPanel6.Name = "tableLayoutPanel6";
            this.tableLayoutPanel6.RowCount = 1;
            this.tableLayoutPanel6.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel6.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 25F));
            this.tableLayoutPanel6.Size = new System.Drawing.Size(214, 25);
            this.tableLayoutPanel6.TabIndex = 5;
            // 
            // lbl_pos_blade_03
            // 
            this.lbl_pos_blade_03.AutoSize = true;
            this.lbl_pos_blade_03.Dock = System.Windows.Forms.DockStyle.Right;
            this.lbl_pos_blade_03.Enabled = false;
            this.lbl_pos_blade_03.Location = new System.Drawing.Point(6, 0);
            this.lbl_pos_blade_03.Name = "lbl_pos_blade_03";
            this.lbl_pos_blade_03.Size = new System.Drawing.Size(76, 25);
            this.lbl_pos_blade_03.TabIndex = 0;
            this.lbl_pos_blade_03.Text = "Pos. Blade 03:";
            this.lbl_pos_blade_03.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // nud_control_pos_blade_03
            // 
            this.nud_control_pos_blade_03.Dock = System.Windows.Forms.DockStyle.Fill;
            this.nud_control_pos_blade_03.Enabled = false;
            this.nud_control_pos_blade_03.Location = new System.Drawing.Point(88, 3);
            this.nud_control_pos_blade_03.Maximum = new decimal(new int[] {
            180,
            0,
            0,
            0});
            this.nud_control_pos_blade_03.Name = "nud_control_pos_blade_03";
            this.nud_control_pos_blade_03.Size = new System.Drawing.Size(123, 20);
            this.nud_control_pos_blade_03.TabIndex = 1;
            this.nud_control_pos_blade_03.Value = new decimal(new int[] {
            90,
            0,
            0,
            0});
            this.nud_control_pos_blade_03.ValueChanged += new System.EventHandler(this.Nud_control_pos_blade_03_ValueChanged);
            // 
            // tableLayoutPanel5
            // 
            this.tableLayoutPanel5.ColumnCount = 2;
            this.tableLayoutPanel5.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 39.71963F));
            this.tableLayoutPanel5.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 60.28037F));
            this.tableLayoutPanel5.Controls.Add(this.lbl_pos_blade_02, 0, 0);
            this.tableLayoutPanel5.Controls.Add(this.nud_control_pos_blade_02, 1, 0);
            this.tableLayoutPanel5.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel5.Location = new System.Drawing.Point(0, 100);
            this.tableLayoutPanel5.Margin = new System.Windows.Forms.Padding(0);
            this.tableLayoutPanel5.Name = "tableLayoutPanel5";
            this.tableLayoutPanel5.RowCount = 1;
            this.tableLayoutPanel5.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel5.Size = new System.Drawing.Size(214, 25);
            this.tableLayoutPanel5.TabIndex = 3;
            // 
            // lbl_pos_blade_02
            // 
            this.lbl_pos_blade_02.AutoSize = true;
            this.lbl_pos_blade_02.Dock = System.Windows.Forms.DockStyle.Right;
            this.lbl_pos_blade_02.Enabled = false;
            this.lbl_pos_blade_02.Location = new System.Drawing.Point(6, 0);
            this.lbl_pos_blade_02.Name = "lbl_pos_blade_02";
            this.lbl_pos_blade_02.Size = new System.Drawing.Size(76, 25);
            this.lbl_pos_blade_02.TabIndex = 0;
            this.lbl_pos_blade_02.Text = "Pos. Blade 02:";
            this.lbl_pos_blade_02.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // nud_control_pos_blade_02
            // 
            this.nud_control_pos_blade_02.Dock = System.Windows.Forms.DockStyle.Fill;
            this.nud_control_pos_blade_02.Enabled = false;
            this.nud_control_pos_blade_02.Location = new System.Drawing.Point(88, 3);
            this.nud_control_pos_blade_02.Maximum = new decimal(new int[] {
            180,
            0,
            0,
            0});
            this.nud_control_pos_blade_02.Name = "nud_control_pos_blade_02";
            this.nud_control_pos_blade_02.Size = new System.Drawing.Size(123, 20);
            this.nud_control_pos_blade_02.TabIndex = 1;
            this.nud_control_pos_blade_02.Value = new decimal(new int[] {
            90,
            0,
            0,
            0});
            this.nud_control_pos_blade_02.ValueChanged += new System.EventHandler(this.Nud_control_pos_blade_02_ValueChanged);
            // 
            // cb_controll_simultaeously
            // 
            this.cb_controll_simultaeously.AutoSize = true;
            this.cb_controll_simultaeously.Checked = true;
            this.cb_controll_simultaeously.CheckState = System.Windows.Forms.CheckState.Checked;
            this.cb_controll_simultaeously.Dock = System.Windows.Forms.DockStyle.Fill;
            this.cb_controll_simultaeously.Location = new System.Drawing.Point(3, 3);
            this.cb_controll_simultaeously.Name = "cb_controll_simultaeously";
            this.cb_controll_simultaeously.Size = new System.Drawing.Size(208, 19);
            this.cb_controll_simultaeously.TabIndex = 0;
            this.cb_controll_simultaeously.Text = "control simultaneously";
            this.cb_controll_simultaeously.UseVisualStyleBackColor = true;
            this.cb_controll_simultaeously.CheckedChanged += new System.EventHandler(this.Cb_controll_simultainiously_CheckedChanged);
            // 
            // tbs_control_pos_blade_01
            // 
            this.tbs_control_pos_blade_01.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tbs_control_pos_blade_01.Location = new System.Drawing.Point(3, 76);
            this.tbs_control_pos_blade_01.Margin = new System.Windows.Forms.Padding(3, 1, 3, 8);
            this.tbs_control_pos_blade_01.Maximum = 180;
            this.tbs_control_pos_blade_01.MaximumSize = new System.Drawing.Size(0, 20);
            this.tbs_control_pos_blade_01.Name = "tbs_control_pos_blade_01";
            this.tbs_control_pos_blade_01.Size = new System.Drawing.Size(208, 16);
            this.tbs_control_pos_blade_01.TabIndex = 1;
            this.tbs_control_pos_blade_01.Value = 80;
            this.tbs_control_pos_blade_01.Scroll += new System.EventHandler(this.Tbs_control_pos_blade_01_Scroll);
            this.tbs_control_pos_blade_01.MouseUp += new System.Windows.Forms.MouseEventHandler(this.Tbs_control_pos_blade_01_MouseUp);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Dock = System.Windows.Forms.DockStyle.Fill;
            this.label3.Location = new System.Drawing.Point(3, 25);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(208, 25);
            this.label3.TabIndex = 1;
            this.label3.Text = "Set Values between 0 - 180";
            // 
            // tableLayoutPanel4
            // 
            this.tableLayoutPanel4.ColumnCount = 2;
            this.tableLayoutPanel4.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 39.71963F));
            this.tableLayoutPanel4.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 60.28037F));
            this.tableLayoutPanel4.Controls.Add(this.lbl_pos_blade_01, 0, 0);
            this.tableLayoutPanel4.Controls.Add(this.nud_control_pos_blade_01, 1, 0);
            this.tableLayoutPanel4.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel4.Location = new System.Drawing.Point(0, 50);
            this.tableLayoutPanel4.Margin = new System.Windows.Forms.Padding(0);
            this.tableLayoutPanel4.Name = "tableLayoutPanel4";
            this.tableLayoutPanel4.RowCount = 1;
            this.tableLayoutPanel4.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel4.Size = new System.Drawing.Size(214, 25);
            this.tableLayoutPanel4.TabIndex = 2;
            // 
            // lbl_pos_blade_01
            // 
            this.lbl_pos_blade_01.AutoSize = true;
            this.lbl_pos_blade_01.Dock = System.Windows.Forms.DockStyle.Right;
            this.lbl_pos_blade_01.Location = new System.Drawing.Point(6, 0);
            this.lbl_pos_blade_01.Name = "lbl_pos_blade_01";
            this.lbl_pos_blade_01.Size = new System.Drawing.Size(76, 25);
            this.lbl_pos_blade_01.TabIndex = 0;
            this.lbl_pos_blade_01.Text = "Pos. Blade 01:";
            this.lbl_pos_blade_01.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // nud_control_pos_blade_01
            // 
            this.nud_control_pos_blade_01.Dock = System.Windows.Forms.DockStyle.Fill;
            this.nud_control_pos_blade_01.Location = new System.Drawing.Point(88, 3);
            this.nud_control_pos_blade_01.Maximum = new decimal(new int[] {
            180,
            0,
            0,
            0});
            this.nud_control_pos_blade_01.Name = "nud_control_pos_blade_01";
            this.nud_control_pos_blade_01.Size = new System.Drawing.Size(123, 20);
            this.nud_control_pos_blade_01.TabIndex = 1;
            this.nud_control_pos_blade_01.Value = new decimal(new int[] {
            90,
            0,
            0,
            0});
            this.nud_control_pos_blade_01.ValueChanged += new System.EventHandler(this.Nud_control_pos_blade_01_ValueChanged);
            // 
            // tbs_control_pos_blade_02
            // 
            this.tbs_control_pos_blade_02.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tbs_control_pos_blade_02.Enabled = false;
            this.tbs_control_pos_blade_02.Location = new System.Drawing.Point(3, 126);
            this.tbs_control_pos_blade_02.Margin = new System.Windows.Forms.Padding(3, 1, 3, 8);
            this.tbs_control_pos_blade_02.Maximum = 180;
            this.tbs_control_pos_blade_02.Name = "tbs_control_pos_blade_02";
            this.tbs_control_pos_blade_02.Size = new System.Drawing.Size(208, 16);
            this.tbs_control_pos_blade_02.TabIndex = 4;
            this.tbs_control_pos_blade_02.Value = 80;
            this.tbs_control_pos_blade_02.Scroll += new System.EventHandler(this.Tbs_control_pos_blade_02_Scroll);
            // 
            // serialPort1
            // 
            this.serialPort1.DataReceived += new System.IO.Ports.SerialDataReceivedEventHandler(this.SerialPort1_DataReceived);
            // 
            // timer_send_data
            // 
            this.timer_send_data.Tick += new System.EventHandler(this.Timer_send_data_Tick);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 451);
            this.Controls.Add(this.tabControl1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MinimumSize = new System.Drawing.Size(816, 489);
            this.Name = "Form1";
            this.Text = "GUI - VD30";
            this.tabControl1.ResumeLayout(false);
            this.tabPage1.ResumeLayout(false);
            this.groupBox2.ResumeLayout(false);
            this.tableLayoutPanel2.ResumeLayout(false);
            this.tableLayoutPanel2.PerformLayout();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.gb_com_controll.ResumeLayout(false);
            this.tableLayoutPanel1.ResumeLayout(false);
            this.tableLayoutPanel1.PerformLayout();
            this.tabPage2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgv_data_datakontainer)).EndInit();
            this.groupBox4.ResumeLayout(false);
            this.groupBox4.PerformLayout();
            this.tableLayoutPanel8.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.chart3)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.chart2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.chart1)).EndInit();
            this.toolStrip1.ResumeLayout(false);
            this.toolStrip1.PerformLayout();
            this.groupBox3.ResumeLayout(false);
            this.tableLayoutPanel3.ResumeLayout(false);
            this.tableLayoutPanel3.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.tbs_control_pos_brake)).EndInit();
            this.tableLayoutPanel7.ResumeLayout(false);
            this.tableLayoutPanel7.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.nud_control_pos_brake)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.tbs_control_pos_blade_03)).EndInit();
            this.tableLayoutPanel6.ResumeLayout(false);
            this.tableLayoutPanel6.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.nud_control_pos_blade_03)).EndInit();
            this.tableLayoutPanel5.ResumeLayout(false);
            this.tableLayoutPanel5.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.nud_control_pos_blade_02)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.tbs_control_pos_blade_01)).EndInit();
            this.tableLayoutPanel4.ResumeLayout(false);
            this.tableLayoutPanel4.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.nud_control_pos_blade_01)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.tbs_control_pos_blade_02)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TabControl tabControl1;
        private System.Windows.Forms.TabPage tabPage2;
        private System.Windows.Forms.TabPage tabPage1;
        private System.Windows.Forms.GroupBox gb_com_controll;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
        private System.Windows.Forms.ComboBox cb_serial_data_com_port;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.ComboBox cb_serial_data_baudrate;
        private System.Windows.Forms.ComboBox cb_serial_data_data_bits;
        private System.Windows.Forms.ComboBox cb_serial_data_stop_bits;
        private System.Windows.Forms.ComboBox cb_serial_data_parity_bits;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label lbl_data_out_length;
        private System.Windows.Forms.Label lbl_data_in_length;
        private System.Windows.Forms.CheckBox cb_serial_data_dtr_enable;
        private System.Windows.Forms.CheckBox cb_serial_data_rts_enable;
        private System.Windows.Forms.Button btn_serial_data_clear;
        private System.Windows.Forms.Button btn_serial_data_send;
        private System.Windows.Forms.TextBox tb_serial_data_receive;
        private System.Windows.Forms.TextBox tb_serial_data_out;
        private System.Windows.Forms.ProgressBar pb_serial_data_status;
        private System.Windows.Forms.Button btn_serial_data_close;
        private System.Windows.Forms.Button btn_serial_data_open;
        private System.Windows.Forms.DataGridView dgv_data_datakontainer;
        private System.Windows.Forms.GroupBox groupBox4;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.TrackBar tbs_control_pos_blade_01;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel3;
        private System.Windows.Forms.CheckBox cb_controll_simultaeously;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel4;
        private System.Windows.Forms.Label lbl_pos_blade_01;
        private System.Windows.Forms.TrackBar tbs_control_pos_brake;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel7;
        private System.Windows.Forms.Label lbl_pos_brake;
        private System.Windows.Forms.NumericUpDown nud_control_pos_brake;
        private System.Windows.Forms.TrackBar tbs_control_pos_blade_03;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel6;
        private System.Windows.Forms.Label lbl_pos_blade_03;
        private System.Windows.Forms.NumericUpDown nud_control_pos_blade_03;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel5;
        private System.Windows.Forms.Label lbl_pos_blade_02;
        private System.Windows.Forms.NumericUpDown nud_control_pos_blade_02;
        private System.Windows.Forms.NumericUpDown nud_control_pos_blade_01;
        private System.Windows.Forms.TrackBar tbs_control_pos_blade_02;
        private System.Windows.Forms.Button btn_control_send_blade_pos;
        private System.Windows.Forms.ToolStrip toolStrip1;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator1;
        private System.Windows.Forms.ToolStripButton tsb_help;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel8;
        private System.Windows.Forms.DataVisualization.Charting.Chart chart1;
        private System.Windows.Forms.DataGridViewTextBoxColumn dg_col_time;
        private System.Windows.Forms.DataGridViewTextBoxColumn dg_col_hll_sens;
        private System.Windows.Forms.DataGridViewTextBoxColumn dg_col_load_cell_01;
        private System.Windows.Forms.DataGridViewTextBoxColumn dg_col_load_cell_02;
        private System.Windows.Forms.DataGridViewTextBoxColumn dg_col_Break_val;
        private System.Windows.Forms.DataGridViewTextBoxColumn dg_col_blade_01;
        private System.Windows.Forms.DataGridViewTextBoxColumn dg_col_blade_02;
        private System.Windows.Forms.DataGridViewTextBoxColumn dg_col_blade_03;
        private System.Windows.Forms.DataVisualization.Charting.Chart chart3;
        private System.Windows.Forms.DataVisualization.Charting.Chart chart2;
        private System.IO.Ports.SerialPort serialPort1;
        private System.Windows.Forms.Timer timer_date;
        private System.Windows.Forms.ToolStripLabel tsl_mause_x;
        private System.Windows.Forms.ToolStripLabel tsl_mause_y;
        private System.Windows.Forms.ToolStripLabel tsl_zoomfactor;
        private System.Windows.Forms.ToolStripButton tsb_save_txt;
        private System.Windows.Forms.ToolStripButton tsb_save_excel;
        private System.Windows.Forms.ToolStripLabel tsl_timer;
        private System.Windows.Forms.Timer timer_send_data;
    }
}


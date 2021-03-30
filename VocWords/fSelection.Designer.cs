namespace VocWords
{
    partial class fSelection
    {
        /// <summary>
        /// Обязательная переменная конструктора.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Освободить все используемые ресурсы.
        /// </summary>
        /// <param name="disposing">истинно, если управляемый ресурс должен быть удален; иначе ложно.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Код, автоматически созданный конструктором форм Windows

        /// <summary>
        /// Требуемый метод для поддержки конструктора — не изменяйте 
        /// содержимое этого метода с помощью редактора кода.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(fSelection));
            this.tabControl1 = new System.Windows.Forms.TabControl();
            this.tabPage1 = new System.Windows.Forms.TabPage();
            this.label5 = new System.Windows.Forms.Label();
            this.cb_OFFHELP = new System.Windows.Forms.CheckBox();
            this.lbl_favorite = new System.Windows.Forms.Label();
            this.btn_DOWNLOAD = new System.Windows.Forms.Button();
            this.cb_RELAY_MODE = new System.Windows.Forms.CheckBox();
            this.cb_noGood = new System.Windows.Forms.CheckBox();
            this.lbl_x = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            this.cb_bad = new System.Windows.Forms.CheckBox();
            this.cb_all = new System.Windows.Forms.CheckBox();
            this.lbl_CORRECT = new System.Windows.Forms.Label();
            this.lbl_good = new System.Windows.Forms.Label();
            this.lbl_bad = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.btn_Check = new System.Windows.Forms.Button();
            this.txb_WORD = new System.Windows.Forms.TextBox();
            this.rb_ALL = new System.Windows.Forms.RadioButton();
            this.rb_RUS = new System.Windows.Forms.RadioButton();
            this.rb_ENG = new System.Windows.Forms.RadioButton();
            this.lbl_RANDWORD = new System.Windows.Forms.Label();
            this.tabPage2 = new System.Windows.Forms.TabPage();
            this.fullTableWordsBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.vocWordsDataSet = new VocWords.VocWordsDataSet();
            this.tb_RUS3 = new System.Windows.Forms.TextBox();
            this.tb_RUS2 = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.tb_DESCRIPTION = new System.Windows.Forms.TextBox();
            this.lbl_LOG = new System.Windows.Forms.Label();
            this.btn_FIND = new System.Windows.Forms.Button();
            this.tb_RUS = new System.Windows.Forms.TextBox();
            this.tb_ENG = new System.Windows.Forms.TextBox();
            this.btn_ADD = new System.Windows.Forms.Button();
            this.lbl_RUS = new System.Windows.Forms.Label();
            this.lbl_ENG = new System.Windows.Forms.Label();
            this.fullTableWordsTableAdapter = new VocWords.VocWordsDataSetTableAdapters.FullTableWordsTableAdapter();
            this.tableAdapterManager = new VocWords.VocWordsDataSetTableAdapters.TableAdapterManager();
            this.fullTableWordsDataGridView = new System.Windows.Forms.DataGridView();
            this.dataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn4 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn5 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn6 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn7 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn3 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.tabControl1.SuspendLayout();
            this.tabPage1.SuspendLayout();
            this.tabPage2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.fullTableWordsBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.vocWordsDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.fullTableWordsDataGridView)).BeginInit();
            this.SuspendLayout();
            // 
            // tabControl1
            // 
            this.tabControl1.Controls.Add(this.tabPage1);
            this.tabControl1.Controls.Add(this.tabPage2);
            this.tabControl1.Location = new System.Drawing.Point(12, 12);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(802, 494);
            this.tabControl1.TabIndex = 2;
            // 
            // tabPage1
            // 
            this.tabPage1.BackColor = System.Drawing.SystemColors.ButtonFace;
            this.tabPage1.Controls.Add(this.label5);
            this.tabPage1.Controls.Add(this.cb_OFFHELP);
            this.tabPage1.Controls.Add(this.lbl_favorite);
            this.tabPage1.Controls.Add(this.btn_DOWNLOAD);
            this.tabPage1.Controls.Add(this.cb_RELAY_MODE);
            this.tabPage1.Controls.Add(this.cb_noGood);
            this.tabPage1.Controls.Add(this.lbl_x);
            this.tabPage1.Controls.Add(this.label4);
            this.tabPage1.Controls.Add(this.button1);
            this.tabPage1.Controls.Add(this.cb_bad);
            this.tabPage1.Controls.Add(this.cb_all);
            this.tabPage1.Controls.Add(this.lbl_CORRECT);
            this.tabPage1.Controls.Add(this.lbl_good);
            this.tabPage1.Controls.Add(this.lbl_bad);
            this.tabPage1.Controls.Add(this.label2);
            this.tabPage1.Controls.Add(this.label1);
            this.tabPage1.Controls.Add(this.btn_Check);
            this.tabPage1.Controls.Add(this.txb_WORD);
            this.tabPage1.Controls.Add(this.rb_ALL);
            this.tabPage1.Controls.Add(this.rb_RUS);
            this.tabPage1.Controls.Add(this.rb_ENG);
            this.tabPage1.Controls.Add(this.lbl_RANDWORD);
            this.tabPage1.Location = new System.Drawing.Point(4, 25);
            this.tabPage1.Name = "tabPage1";
            this.tabPage1.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage1.Size = new System.Drawing.Size(794, 465);
            this.tabPage1.TabIndex = 0;
            this.tabPage1.Text = "ПРОВЕРКА";
            // 
            // label5
            // 
            this.label5.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label5.ForeColor = System.Drawing.Color.Green;
            this.label5.Image = ((System.Drawing.Image)(resources.GetObject("label5.Image")));
            this.label5.Location = new System.Drawing.Point(4, 3);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(32, 32);
            this.label5.TabIndex = 42;
            this.label5.Click += new System.EventHandler(this.label5_Click);
            // 
            // cb_OFFHELP
            // 
            this.cb_OFFHELP.AutoSize = true;
            this.cb_OFFHELP.BackColor = System.Drawing.SystemColors.GradientActiveCaption;
            this.cb_OFFHELP.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.cb_OFFHELP.Location = new System.Drawing.Point(144, 428);
            this.cb_OFFHELP.Name = "cb_OFFHELP";
            this.cb_OFFHELP.Size = new System.Drawing.Size(175, 21);
            this.cb_OFFHELP.TabIndex = 41;
            this.cb_OFFHELP.Text = "Отключить подсказки";
            this.cb_OFFHELP.UseVisualStyleBackColor = false;
            // 
            // lbl_favorite
            // 
            this.lbl_favorite.AutoSize = true;
            this.lbl_favorite.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.lbl_favorite.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.lbl_favorite.ForeColor = System.Drawing.Color.Green;
            this.lbl_favorite.Location = new System.Drawing.Point(756, 3);
            this.lbl_favorite.Name = "lbl_favorite";
            this.lbl_favorite.Size = new System.Drawing.Size(32, 32);
            this.lbl_favorite.TabIndex = 40;
            this.lbl_favorite.Text = "+";
            this.lbl_favorite.Click += new System.EventHandler(this.lbl_favorite_Click);
            // 
            // btn_DOWNLOAD
            // 
            this.btn_DOWNLOAD.Location = new System.Drawing.Point(623, 436);
            this.btn_DOWNLOAD.Name = "btn_DOWNLOAD";
            this.btn_DOWNLOAD.Size = new System.Drawing.Size(165, 23);
            this.btn_DOWNLOAD.TabIndex = 39;
            this.btn_DOWNLOAD.Text = "Обновление 5к слов";
            this.btn_DOWNLOAD.UseVisualStyleBackColor = true;
            this.btn_DOWNLOAD.Click += new System.EventHandler(this.btn_DOWNLOAD_Click);
            // 
            // cb_RELAY_MODE
            // 
            this.cb_RELAY_MODE.AutoSize = true;
            this.cb_RELAY_MODE.BackColor = System.Drawing.SystemColors.GradientActiveCaption;
            this.cb_RELAY_MODE.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.cb_RELAY_MODE.Location = new System.Drawing.Point(6, 428);
            this.cb_RELAY_MODE.Name = "cb_RELAY_MODE";
            this.cb_RELAY_MODE.Size = new System.Drawing.Size(84, 21);
            this.cb_RELAY_MODE.TabIndex = 38;
            this.cb_RELAY_MODE.Text = "ALLVOC";
            this.cb_RELAY_MODE.UseVisualStyleBackColor = false;
            this.cb_RELAY_MODE.CheckedChanged += new System.EventHandler(this.cb_RELAY_MODE_CheckedChanged);
            // 
            // cb_noGood
            // 
            this.cb_noGood.AutoSize = true;
            this.cb_noGood.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.cb_noGood.Location = new System.Drawing.Point(273, 398);
            this.cb_noGood.Name = "cb_noGood";
            this.cb_noGood.Size = new System.Drawing.Size(115, 24);
            this.cb_noGood.TabIndex = 37;
            this.cb_noGood.Text = "Без Good";
            this.cb_noGood.UseVisualStyleBackColor = true;
            this.cb_noGood.CheckedChanged += new System.EventHandler(this.cb_noGood_CheckedChanged);
            // 
            // lbl_x
            // 
            this.lbl_x.AutoSize = true;
            this.lbl_x.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.lbl_x.ForeColor = System.Drawing.Color.SteelBlue;
            this.lbl_x.Location = new System.Drawing.Point(694, 321);
            this.lbl_x.Name = "lbl_x";
            this.lbl_x.Size = new System.Drawing.Size(19, 20);
            this.lbl_x.TabIndex = 36;
            this.lbl_x.Text = "0";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label4.ForeColor = System.Drawing.Color.SteelBlue;
            this.label4.Location = new System.Drawing.Point(647, 321);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(21, 20);
            this.label4.TabIndex = 35;
            this.label4.Text = "X";
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(742, 224);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(46, 45);
            this.button1.TabIndex = 34;
            this.button1.Text = "Х";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // cb_bad
            // 
            this.cb_bad.AutoSize = true;
            this.cb_bad.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.cb_bad.Location = new System.Drawing.Point(144, 398);
            this.cb_bad.Name = "cb_bad";
            this.cb_bad.Size = new System.Drawing.Size(95, 24);
            this.cb_bad.TabIndex = 33;
            this.cb_bad.Text = "По Bad";
            this.cb_bad.UseVisualStyleBackColor = true;
            this.cb_bad.CheckedChanged += new System.EventHandler(this.cb_bad_CheckedChanged);
            // 
            // cb_all
            // 
            this.cb_all.AutoSize = true;
            this.cb_all.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.cb_all.Location = new System.Drawing.Point(6, 398);
            this.cb_all.Name = "cb_all";
            this.cb_all.Size = new System.Drawing.Size(107, 24);
            this.cb_all.TabIndex = 32;
            this.cb_all.Text = "По всем";
            this.cb_all.UseVisualStyleBackColor = true;
            this.cb_all.CheckedChanged += new System.EventHandler(this.cb_all_CheckedChanged);
            // 
            // lbl_CORRECT
            // 
            this.lbl_CORRECT.BackColor = System.Drawing.SystemColors.Control;
            this.lbl_CORRECT.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.lbl_CORRECT.Location = new System.Drawing.Point(6, 272);
            this.lbl_CORRECT.Name = "lbl_CORRECT";
            this.lbl_CORRECT.Size = new System.Drawing.Size(782, 38);
            this.lbl_CORRECT.TabIndex = 31;
            this.lbl_CORRECT.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lbl_good
            // 
            this.lbl_good.AutoSize = true;
            this.lbl_good.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.lbl_good.ForeColor = System.Drawing.Color.Green;
            this.lbl_good.Location = new System.Drawing.Point(410, 322);
            this.lbl_good.Name = "lbl_good";
            this.lbl_good.Size = new System.Drawing.Size(19, 20);
            this.lbl_good.TabIndex = 30;
            this.lbl_good.Text = "0";
            // 
            // lbl_bad
            // 
            this.lbl_bad.AutoSize = true;
            this.lbl_bad.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.lbl_bad.ForeColor = System.Drawing.Color.Red;
            this.lbl_bad.Location = new System.Drawing.Point(125, 321);
            this.lbl_bad.Name = "lbl_bad";
            this.lbl_bad.Size = new System.Drawing.Size(19, 20);
            this.lbl_bad.TabIndex = 29;
            this.lbl_bad.Text = "0";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label2.ForeColor = System.Drawing.Color.Red;
            this.label2.Location = new System.Drawing.Point(64, 321);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(42, 20);
            this.label2.TabIndex = 28;
            this.label2.Text = "Bad";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label1.ForeColor = System.Drawing.Color.Green;
            this.label1.Location = new System.Drawing.Point(347, 321);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(53, 20);
            this.label1.TabIndex = 27;
            this.label1.Text = "Good";
            // 
            // btn_Check
            // 
            this.btn_Check.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.btn_Check.Location = new System.Drawing.Point(6, 224);
            this.btn_Check.Name = "btn_Check";
            this.btn_Check.Size = new System.Drawing.Size(730, 45);
            this.btn_Check.TabIndex = 26;
            this.btn_Check.Text = "ДАЛЬШЕ";
            this.btn_Check.UseVisualStyleBackColor = true;
            this.btn_Check.Click += new System.EventHandler(this.btn_Check_Click);
            // 
            // txb_WORD
            // 
            this.txb_WORD.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.txb_WORD.Location = new System.Drawing.Point(6, 172);
            this.txb_WORD.Multiline = true;
            this.txb_WORD.Name = "txb_WORD";
            this.txb_WORD.Size = new System.Drawing.Size(782, 46);
            this.txb_WORD.TabIndex = 25;
            this.txb_WORD.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.txb_WORD.Enter += new System.EventHandler(this.txb_WORD_Enter);
            this.txb_WORD.KeyDown += new System.Windows.Forms.KeyEventHandler(this.txb_WORD_KeyDown);
            // 
            // rb_ALL
            // 
            this.rb_ALL.AutoSize = true;
            this.rb_ALL.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.rb_ALL.Location = new System.Drawing.Point(273, 362);
            this.rb_ALL.Name = "rb_ALL";
            this.rb_ALL.Size = new System.Drawing.Size(64, 24);
            this.rb_ALL.TabIndex = 24;
            this.rb_ALL.Text = "ALL";
            this.rb_ALL.UseVisualStyleBackColor = true;
            // 
            // rb_RUS
            // 
            this.rb_RUS.AutoSize = true;
            this.rb_RUS.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.rb_RUS.Location = new System.Drawing.Point(144, 362);
            this.rb_RUS.Name = "rb_RUS";
            this.rb_RUS.Size = new System.Drawing.Size(97, 24);
            this.rb_RUS.TabIndex = 23;
            this.rb_RUS.Text = "RUSSIA";
            this.rb_RUS.UseVisualStyleBackColor = true;
            // 
            // rb_ENG
            // 
            this.rb_ENG.AutoSize = true;
            this.rb_ENG.Checked = true;
            this.rb_ENG.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.rb_ENG.Location = new System.Drawing.Point(6, 362);
            this.rb_ENG.Name = "rb_ENG";
            this.rb_ENG.Size = new System.Drawing.Size(111, 24);
            this.rb_ENG.TabIndex = 22;
            this.rb_ENG.TabStop = true;
            this.rb_ENG.Text = "ENGLISH";
            this.rb_ENG.UseVisualStyleBackColor = true;
            // 
            // lbl_RANDWORD
            // 
            this.lbl_RANDWORD.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.lbl_RANDWORD.Font = new System.Drawing.Font("Microsoft Sans Serif", 19.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.lbl_RANDWORD.ForeColor = System.Drawing.Color.White;
            this.lbl_RANDWORD.Location = new System.Drawing.Point(3, 3);
            this.lbl_RANDWORD.Name = "lbl_RANDWORD";
            this.lbl_RANDWORD.Size = new System.Drawing.Size(788, 166);
            this.lbl_RANDWORD.TabIndex = 21;
            this.lbl_RANDWORD.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // tabPage2
            // 
            this.tabPage2.AutoScroll = true;
            this.tabPage2.BackColor = System.Drawing.SystemColors.ButtonFace;
            this.tabPage2.Controls.Add(this.fullTableWordsDataGridView);
            this.tabPage2.Controls.Add(this.tb_RUS3);
            this.tabPage2.Controls.Add(this.tb_RUS2);
            this.tabPage2.Controls.Add(this.label3);
            this.tabPage2.Controls.Add(this.tb_DESCRIPTION);
            this.tabPage2.Controls.Add(this.lbl_LOG);
            this.tabPage2.Controls.Add(this.btn_FIND);
            this.tabPage2.Controls.Add(this.tb_RUS);
            this.tabPage2.Controls.Add(this.tb_ENG);
            this.tabPage2.Controls.Add(this.btn_ADD);
            this.tabPage2.Controls.Add(this.lbl_RUS);
            this.tabPage2.Controls.Add(this.lbl_ENG);
            this.tabPage2.Location = new System.Drawing.Point(4, 25);
            this.tabPage2.Name = "tabPage2";
            this.tabPage2.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage2.Size = new System.Drawing.Size(794, 465);
            this.tabPage2.TabIndex = 1;
            this.tabPage2.Text = "ДОБАВЛЕНИЕ";
            // 
            // fullTableWordsBindingSource
            // 
            this.fullTableWordsBindingSource.DataMember = "FullTableWords";
            this.fullTableWordsBindingSource.DataSource = this.vocWordsDataSet;
            // 
            // vocWordsDataSet
            // 
            this.vocWordsDataSet.DataSetName = "VocWordsDataSet";
            this.vocWordsDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // tb_RUS3
            // 
            this.tb_RUS3.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.tb_RUS3.Location = new System.Drawing.Point(467, 309);
            this.tb_RUS3.Name = "tb_RUS3";
            this.tb_RUS3.Size = new System.Drawing.Size(120, 24);
            this.tb_RUS3.TabIndex = 22;
            // 
            // tb_RUS2
            // 
            this.tb_RUS2.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.tb_RUS2.Location = new System.Drawing.Point(341, 309);
            this.tb_RUS2.Name = "tb_RUS2";
            this.tb_RUS2.Size = new System.Drawing.Size(120, 24);
            this.tb_RUS2.TabIndex = 21;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label3.Location = new System.Drawing.Point(6, 338);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(99, 20);
            this.label3.TabIndex = 20;
            this.label3.Text = "Описание";
            // 
            // tb_DESCRIPTION
            // 
            this.tb_DESCRIPTION.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.tb_DESCRIPTION.Location = new System.Drawing.Point(215, 338);
            this.tb_DESCRIPTION.Multiline = true;
            this.tb_DESCRIPTION.Name = "tb_DESCRIPTION";
            this.tb_DESCRIPTION.Size = new System.Drawing.Size(372, 42);
            this.tb_DESCRIPTION.TabIndex = 18;
            // 
            // lbl_LOG
            // 
            this.lbl_LOG.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.lbl_LOG.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.lbl_LOG.ForeColor = System.Drawing.Color.ForestGreen;
            this.lbl_LOG.Location = new System.Drawing.Point(6, 383);
            this.lbl_LOG.Name = "lbl_LOG";
            this.lbl_LOG.Size = new System.Drawing.Size(773, 68);
            this.lbl_LOG.TabIndex = 17;
            this.lbl_LOG.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // btn_FIND
            // 
            this.btn_FIND.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.btn_FIND.Location = new System.Drawing.Point(593, 338);
            this.btn_FIND.Name = "btn_FIND";
            this.btn_FIND.Size = new System.Drawing.Size(183, 42);
            this.btn_FIND.TabIndex = 13;
            this.btn_FIND.Text = "НАЙТИ";
            this.btn_FIND.UseVisualStyleBackColor = true;
            this.btn_FIND.Click += new System.EventHandler(this.btn_FIND_Click);
            // 
            // tb_RUS
            // 
            this.tb_RUS.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.tb_RUS.Location = new System.Drawing.Point(215, 309);
            this.tb_RUS.Name = "tb_RUS";
            this.tb_RUS.Size = new System.Drawing.Size(120, 24);
            this.tb_RUS.TabIndex = 15;
            // 
            // tb_ENG
            // 
            this.tb_ENG.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.tb_ENG.Location = new System.Drawing.Point(215, 281);
            this.tb_ENG.Name = "tb_ENG";
            this.tb_ENG.Size = new System.Drawing.Size(372, 24);
            this.tb_ENG.TabIndex = 14;
            this.tb_ENG.Enter += new System.EventHandler(this.tb_ENG_Enter);
            this.tb_ENG.Leave += new System.EventHandler(this.tb_ENG_Leave);
            // 
            // btn_ADD
            // 
            this.btn_ADD.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.btn_ADD.Location = new System.Drawing.Point(593, 281);
            this.btn_ADD.Name = "btn_ADD";
            this.btn_ADD.Size = new System.Drawing.Size(183, 52);
            this.btn_ADD.TabIndex = 16;
            this.btn_ADD.Text = "ДОБАВИТЬ";
            this.btn_ADD.UseVisualStyleBackColor = true;
            this.btn_ADD.Click += new System.EventHandler(this.btn_ADD_Click);
            // 
            // lbl_RUS
            // 
            this.lbl_RUS.AutoSize = true;
            this.lbl_RUS.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.lbl_RUS.Location = new System.Drawing.Point(6, 309);
            this.lbl_RUS.Name = "lbl_RUS";
            this.lbl_RUS.Size = new System.Drawing.Size(142, 20);
            this.lbl_RUS.TabIndex = 12;
            this.lbl_RUS.Text = "Русское слово";
            // 
            // lbl_ENG
            // 
            this.lbl_ENG.AutoSize = true;
            this.lbl_ENG.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.lbl_ENG.Location = new System.Drawing.Point(6, 281);
            this.lbl_ENG.Name = "lbl_ENG";
            this.lbl_ENG.Size = new System.Drawing.Size(177, 20);
            this.lbl_ENG.TabIndex = 11;
            this.lbl_ENG.Text = "Английское слово";
            // 
            // fullTableWordsTableAdapter
            // 
            this.fullTableWordsTableAdapter.ClearBeforeFill = true;
            // 
            // tableAdapterManager
            // 
            this.tableAdapterManager.BackupDataSetBeforeUpdate = false;
            this.tableAdapterManager.Connection = null;
            this.tableAdapterManager.STATUS_WORDSTableAdapter = null;
            this.tableAdapterManager.UpdateOrder = VocWords.VocWordsDataSetTableAdapters.TableAdapterManager.UpdateOrderOption.InsertUpdateDelete;
            this.tableAdapterManager.WORDS_ALLTableAdapter = null;
            this.tableAdapterManager.WORDSTableAdapter = null;
            // 
            // fullTableWordsDataGridView
            // 
            this.fullTableWordsDataGridView.AutoGenerateColumns = false;
            this.fullTableWordsDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.fullTableWordsDataGridView.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.dataGridViewTextBoxColumn1,
            this.dataGridViewTextBoxColumn4,
            this.dataGridViewTextBoxColumn5,
            this.dataGridViewTextBoxColumn6,
            this.dataGridViewTextBoxColumn7,
            this.dataGridViewTextBoxColumn3,
            this.dataGridViewTextBoxColumn2});
            this.fullTableWordsDataGridView.DataSource = this.fullTableWordsBindingSource;
            this.fullTableWordsDataGridView.Location = new System.Drawing.Point(6, 6);
            this.fullTableWordsDataGridView.Name = "fullTableWordsDataGridView";
            this.fullTableWordsDataGridView.RowHeadersWidth = 51;
            this.fullTableWordsDataGridView.RowTemplate.Height = 24;
            this.fullTableWordsDataGridView.Size = new System.Drawing.Size(782, 269);
            this.fullTableWordsDataGridView.TabIndex = 22;
            // 
            // dataGridViewTextBoxColumn1
            // 
            this.dataGridViewTextBoxColumn1.DataPropertyName = "ID";
            this.dataGridViewTextBoxColumn1.HeaderText = "ID";
            this.dataGridViewTextBoxColumn1.MinimumWidth = 6;
            this.dataGridViewTextBoxColumn1.Name = "dataGridViewTextBoxColumn1";
            this.dataGridViewTextBoxColumn1.Width = 30;
            // 
            // dataGridViewTextBoxColumn4
            // 
            this.dataGridViewTextBoxColumn4.DataPropertyName = "Eng";
            this.dataGridViewTextBoxColumn4.HeaderText = "Eng";
            this.dataGridViewTextBoxColumn4.MinimumWidth = 6;
            this.dataGridViewTextBoxColumn4.Name = "dataGridViewTextBoxColumn4";
            this.dataGridViewTextBoxColumn4.Width = 110;
            // 
            // dataGridViewTextBoxColumn5
            // 
            this.dataGridViewTextBoxColumn5.DataPropertyName = "Rus";
            this.dataGridViewTextBoxColumn5.HeaderText = "Rus";
            this.dataGridViewTextBoxColumn5.MinimumWidth = 6;
            this.dataGridViewTextBoxColumn5.Name = "dataGridViewTextBoxColumn5";
            this.dataGridViewTextBoxColumn5.Width = 110;
            // 
            // dataGridViewTextBoxColumn6
            // 
            this.dataGridViewTextBoxColumn6.DataPropertyName = "Rus2";
            this.dataGridViewTextBoxColumn6.HeaderText = "Rus2";
            this.dataGridViewTextBoxColumn6.MinimumWidth = 6;
            this.dataGridViewTextBoxColumn6.Name = "dataGridViewTextBoxColumn6";
            this.dataGridViewTextBoxColumn6.Width = 110;
            // 
            // dataGridViewTextBoxColumn7
            // 
            this.dataGridViewTextBoxColumn7.DataPropertyName = "Rus3";
            this.dataGridViewTextBoxColumn7.HeaderText = "Rus3";
            this.dataGridViewTextBoxColumn7.MinimumWidth = 6;
            this.dataGridViewTextBoxColumn7.Name = "dataGridViewTextBoxColumn7";
            this.dataGridViewTextBoxColumn7.Width = 110;
            // 
            // dataGridViewTextBoxColumn3
            // 
            this.dataGridViewTextBoxColumn3.DataPropertyName = "Статус";
            this.dataGridViewTextBoxColumn3.HeaderText = "Статус";
            this.dataGridViewTextBoxColumn3.MinimumWidth = 6;
            this.dataGridViewTextBoxColumn3.Name = "dataGridViewTextBoxColumn3";
            this.dataGridViewTextBoxColumn3.Width = 45;
            // 
            // dataGridViewTextBoxColumn2
            // 
            this.dataGridViewTextBoxColumn2.DataPropertyName = "Описание";
            this.dataGridViewTextBoxColumn2.HeaderText = "Описание";
            this.dataGridViewTextBoxColumn2.MinimumWidth = 6;
            this.dataGridViewTextBoxColumn2.Name = "dataGridViewTextBoxColumn2";
            this.dataGridViewTextBoxColumn2.Visible = false;
            this.dataGridViewTextBoxColumn2.Width = 125;
            // 
            // fSelection
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(824, 518);
            this.Controls.Add(this.tabControl1);
            this.Name = "fSelection";
            this.Text = "VocWords";
            this.Load += new System.EventHandler(this.fSelection_Load);
            this.tabControl1.ResumeLayout(false);
            this.tabPage1.ResumeLayout(false);
            this.tabPage1.PerformLayout();
            this.tabPage2.ResumeLayout(false);
            this.tabPage2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.fullTableWordsBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.vocWordsDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.fullTableWordsDataGridView)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.TabControl tabControl1;
        private System.Windows.Forms.TabPage tabPage1;
        private System.Windows.Forms.TabPage tabPage2;
        public System.Windows.Forms.CheckBox cb_RELAY_MODE;
        private System.Windows.Forms.CheckBox cb_noGood;
        private System.Windows.Forms.Label lbl_x;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.CheckBox cb_bad;
        private System.Windows.Forms.CheckBox cb_all;
        public System.Windows.Forms.Label lbl_CORRECT;
        private System.Windows.Forms.Label lbl_good;
        private System.Windows.Forms.Label lbl_bad;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btn_Check;
        public System.Windows.Forms.TextBox txb_WORD;
        private System.Windows.Forms.RadioButton rb_ALL;
        private System.Windows.Forms.RadioButton rb_RUS;
        private System.Windows.Forms.RadioButton rb_ENG;
        public System.Windows.Forms.Label lbl_RANDWORD;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox tb_DESCRIPTION;
        private System.Windows.Forms.Label lbl_LOG;
        private System.Windows.Forms.Button btn_FIND;
        private System.Windows.Forms.TextBox tb_RUS;
        private System.Windows.Forms.TextBox tb_ENG;
        private System.Windows.Forms.Button btn_ADD;
        private System.Windows.Forms.Label lbl_RUS;
        private System.Windows.Forms.Label lbl_ENG;
        private VocWordsDataSet vocWordsDataSet;
        private System.Windows.Forms.BindingSource fullTableWordsBindingSource;
        private VocWordsDataSetTableAdapters.FullTableWordsTableAdapter fullTableWordsTableAdapter;
        private System.Windows.Forms.Button btn_DOWNLOAD;
        private System.Windows.Forms.Label lbl_favorite;
        public System.Windows.Forms.CheckBox cb_OFFHELP;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox tb_RUS3;
        private System.Windows.Forms.TextBox tb_RUS2;
        private VocWordsDataSetTableAdapters.TableAdapterManager tableAdapterManager;
        private System.Windows.Forms.DataGridView fullTableWordsDataGridView;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn1;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn4;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn5;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn6;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn7;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn3;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn2;
    }
}


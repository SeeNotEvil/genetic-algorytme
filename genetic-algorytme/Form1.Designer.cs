using core.bl;
namespace genetic_algorytme
{
    partial class Form1
    {
        /// <summary>
        /// Требуется переменная конструктора.
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
        /// Обязательный метод для поддержки конструктора - не изменяйте
        /// содержимое данного метода при помощи редактора кода.
        /// </summary>
        private void InitializeComponent()
        {
            this.resultLabel = new System.Windows.Forms.Label();
            this.resultTextBox = new System.Windows.Forms.TextBox();
            this.vectorSolution = new System.Windows.Forms.Label();
            this.labelFunctionSolution = new System.Windows.Forms.Label();
            this.textBoxResultFitness = new System.Windows.Forms.TextBox();
            this.labelCountRestrict = new System.Windows.Forms.Label();
            this.countRestrictText = new System.Windows.Forms.TextBox();
            this.createFunctionBut = new System.Windows.Forms.Button();
            this.countVariableText = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.tabControlOption = new System.Windows.Forms.TabControl();
            this.tabPage1 = new System.Windows.Forms.TabPage();
 
            this.panelSolution = new System.Windows.Forms.Panel();
            this.butLastPage = new System.Windows.Forms.Button();
            this.buttonCalculate = new System.Windows.Forms.Button();
            this.panelFunction = new System.Windows.Forms.Panel();
            this.labelCursor = new System.Windows.Forms.Label();
            this.panelFunctionRestrict = new System.Windows.Forms.Panel();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.tabPage2 = new System.Windows.Forms.TabPage();
            this.comboBoxAlgoritme = new System.Windows.Forms.ComboBox();
            this.label17 = new System.Windows.Forms.Label();
            this.comboBoxInteger = new System.Windows.Forms.ComboBox();
            this.textCountPopulate = new System.Windows.Forms.TextBox();
            this.textCountGeneration = new System.Windows.Forms.TextBox();
            this.textValueMutation = new System.Windows.Forms.TextBox();
            this.textChanceMutation = new System.Windows.Forms.TextBox();
            this.label13 = new System.Windows.Forms.Label();
            this.countPopulateLabel = new System.Windows.Forms.Label();
            this.countGenerationLabel = new System.Windows.Forms.Label();
            this.labelSizeMutation = new System.Windows.Forms.Label();
            this.labelChanceMutation = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.butReturnResult = new System.Windows.Forms.Button();
            this.label7 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.label12 = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.label11 = new System.Windows.Forms.Label();
            this.panelResult = new System.Windows.Forms.Panel();
            this.label16 = new System.Windows.Forms.Label();
            this.timeBox = new System.Windows.Forms.TextBox();
            this.label15 = new System.Windows.Forms.Label();
            this.butSaveDocument = new System.Windows.Forms.Button();
            this.panelTextsResult2 = new System.Windows.Forms.Panel();
            this.resultTextFunction2 = new System.Windows.Forms.TextBox();
            this.panelTextsResult = new System.Windows.Forms.Panel();
            this.resultTextFunction = new System.Windows.Forms.TextBox();
            this.reCalculate = new System.Windows.Forms.Button();
            this.lastButFunction = new System.Windows.Forms.Button();
            this.label6 = new System.Windows.Forms.Label();
            this.label14 = new System.Windows.Forms.Label();
            this.butMaxMin = new System.Windows.Forms.ComboBox();
            this.saveFileDialog = new System.Windows.Forms.SaveFileDialog();
            this.progressBarResult = new System.Windows.Forms.ProgressBar();
            this.panel1.SuspendLayout();
            this.tabControlOption.SuspendLayout();
            this.tabPage1.SuspendLayout();
            this.panelSolution.SuspendLayout();
            this.panelFunction.SuspendLayout();
            this.tabPage2.SuspendLayout();
            this.panelResult.SuspendLayout();
            this.panelTextsResult2.SuspendLayout();
            this.panelTextsResult.SuspendLayout();
            this.SuspendLayout();
            // 
            // resultLabel
            // 
            this.resultLabel.AutoSize = true;
            this.resultLabel.Location = new System.Drawing.Point(272, 114);
            this.resultLabel.Name = "resultLabel";
            this.resultLabel.Size = new System.Drawing.Size(99, 13);
            this.resultLabel.TabIndex = 2;
            this.resultLabel.Text = "Результат работы";
            // 
            // resultTextBox
            // 
            this.resultTextBox.Location = new System.Drawing.Point(198, 184);
            this.resultTextBox.Name = "resultTextBox";
            this.resultTextBox.Size = new System.Drawing.Size(47, 20);
            this.resultTextBox.TabIndex = 3;
            // 
            // vectorSolution
            // 
            this.vectorSolution.AutoSize = true;
            this.vectorSolution.Location = new System.Drawing.Point(22, 184);
            this.vectorSolution.Name = "vectorSolution";
            this.vectorSolution.Size = new System.Drawing.Size(90, 13);
            this.vectorSolution.TabIndex = 4;
            this.vectorSolution.Text = "Вектор решения";
            // 
            // labelFunctionSolution
            // 
            this.labelFunctionSolution.AutoSize = true;
            this.labelFunctionSolution.Location = new System.Drawing.Point(22, 224);
            this.labelFunctionSolution.Name = "labelFunctionSolution";
            this.labelFunctionSolution.Size = new System.Drawing.Size(149, 13);
            this.labelFunctionSolution.TabIndex = 5;
            this.labelFunctionSolution.Text = "Значение целевой функции ";
            // 
            // textBoxResultFitness
            // 
            this.textBoxResultFitness.Location = new System.Drawing.Point(198, 221);
            this.textBoxResultFitness.Name = "textBoxResultFitness";
            this.textBoxResultFitness.Size = new System.Drawing.Size(47, 20);
            this.textBoxResultFitness.TabIndex = 3;
            // 
            // labelCountRestrict
            // 
            this.labelCountRestrict.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.labelCountRestrict.AutoSize = true;
            this.labelCountRestrict.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.labelCountRestrict.Location = new System.Drawing.Point(3, 0);
            this.labelCountRestrict.Name = "labelCountRestrict";
            this.labelCountRestrict.Size = new System.Drawing.Size(162, 20);
            this.labelCountRestrict.TabIndex = 2;
            this.labelCountRestrict.Text = "Кол-во ограничений";
            // 
            // countRestrictText
            // 
            this.countRestrictText.Location = new System.Drawing.Point(171, 2);
            this.countRestrictText.MaxLength = 2;
            this.countRestrictText.Name = "countRestrictText";
            this.countRestrictText.Size = new System.Drawing.Size(68, 20);
            this.countRestrictText.TabIndex = 3;
            // 
            // createFunctionBut
            // 
            this.createFunctionBut.Location = new System.Drawing.Point(168, 85);
            this.createFunctionBut.Name = "createFunctionBut";
            this.createFunctionBut.Size = new System.Drawing.Size(71, 23);
            this.createFunctionBut.TabIndex = 1;
            this.createFunctionBut.Text = "Далее ";
            this.createFunctionBut.UseVisualStyleBackColor = true;
            this.createFunctionBut.Click += new System.EventHandler(this.nextBut_Click);
            // 
            // countVariableText
            // 
            this.countVariableText.Location = new System.Drawing.Point(171, 43);
            this.countVariableText.MaxLength = 2;
            this.countVariableText.Name = "countVariableText";
            this.countVariableText.Size = new System.Drawing.Size(68, 20);
            this.countVariableText.TabIndex = 3;
            // 
            // label1
            // 
            this.label1.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label1.Location = new System.Drawing.Point(3, 41);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(157, 20);
            this.label1.TabIndex = 2;
            this.label1.Text = "Кол-во переменных";
            // 
            // panel1
            // 
            this.panel1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.panel1.Controls.Add(this.label1);
            this.panel1.Controls.Add(this.countVariableText);
            this.panel1.Controls.Add(this.createFunctionBut);
            this.panel1.Controls.Add(this.countRestrictText);
            this.panel1.Controls.Add(this.labelCountRestrict);
            this.panel1.Location = new System.Drawing.Point(336, 222);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(245, 145);
            this.panel1.TabIndex = 4;
            // 
            // tabControlOption
            // 
            this.tabControlOption.Controls.Add(this.tabPage1);
            this.tabControlOption.Controls.Add(this.tabPage2);
            this.tabControlOption.Location = new System.Drawing.Point(-2, 0);
            this.tabControlOption.Name = "tabControlOption";
            this.tabControlOption.SelectedIndex = 0;
            this.tabControlOption.Size = new System.Drawing.Size(1021, 740);
            this.tabControlOption.TabIndex = 1;
            // 
            // tabPage1
            // 
            this.tabPage1.BackColor = System.Drawing.Color.WhiteSmoke;
            this.tabPage1.Controls.Add(this.panelSolution);
            this.tabPage1.Location = new System.Drawing.Point(4, 22);
            this.tabPage1.Name = "tabPage1";
            this.tabPage1.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage1.Size = new System.Drawing.Size(1013, 714);
            this.tabPage1.TabIndex = 0;
            this.tabPage1.Text = "Задача";

            // panelSolution
            // 
            this.panelSolution.Controls.Add(this.butLastPage);
            this.panelSolution.Controls.Add(this.buttonCalculate);
            this.panelSolution.Controls.Add(this.panelFunction);
            this.panelSolution.Controls.Add(this.panelFunctionRestrict);
            this.panelSolution.Controls.Add(this.label5);
            this.panelSolution.Controls.Add(this.label4);
            this.panelSolution.Location = new System.Drawing.Point(42, 64);
            this.panelSolution.Name = "panelSolution";
            this.panelSolution.Size = new System.Drawing.Size(924, 584);
            this.panelSolution.TabIndex = 1;
            // 
            // butLastPage
            // 
            this.butLastPage.Location = new System.Drawing.Point(3, 554);
            this.butLastPage.Name = "butLastPage";
            this.butLastPage.Size = new System.Drawing.Size(101, 27);
            this.butLastPage.TabIndex = 2;
            this.butLastPage.Text = "Назад";
            this.butLastPage.UseVisualStyleBackColor = true;
            this.butLastPage.Click += new System.EventHandler(this.butLastPage_Click);
            // 
            // buttonCalculate
            // 
            this.buttonCalculate.Location = new System.Drawing.Point(823, 554);
            this.buttonCalculate.Name = "buttonCalculate";
            this.buttonCalculate.Size = new System.Drawing.Size(101, 27);
            this.buttonCalculate.TabIndex = 2;
            this.buttonCalculate.Text = "Посчитать";
            this.buttonCalculate.UseVisualStyleBackColor = true;
            this.buttonCalculate.Click += new System.EventHandler(this.buttonCalculate_Click);
            // 
            // panelFunction
            // 
            this.panelFunction.AutoScroll = true;
            this.panelFunction.Controls.Add(this.labelCursor);
            this.panelFunction.Location = new System.Drawing.Point(73, 470);
            this.panelFunction.Name = "panelFunction";
            this.panelFunction.Size = new System.Drawing.Size(781, 65);
            this.panelFunction.TabIndex = 2;
            // 
            // labelCursor
            // 
            this.labelCursor.AutoSize = true;
            this.labelCursor.Location = new System.Drawing.Point(250, 11);
            this.labelCursor.Name = "labelCursor";
            this.labelCursor.Size = new System.Drawing.Size(25, 13);
            this.labelCursor.TabIndex = 1;
            this.labelCursor.Text = "---->";
            // 
            // panelFunctionRestrict
            // 
            this.panelFunctionRestrict.AutoScroll = true;
            this.panelFunctionRestrict.Location = new System.Drawing.Point(62, 60);
            this.panelFunctionRestrict.Name = "panelFunctionRestrict";
            this.panelFunctionRestrict.Size = new System.Drawing.Size(792, 340);
            this.panelFunctionRestrict.TabIndex = 2;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(424, 448);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(97, 13);
            this.label5.TabIndex = 0;
            this.label5.Text = "Целевая функция";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(425, 30);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(73, 13);
            this.label4.TabIndex = 0;
            this.label4.Text = "Ограничения";
            // 
            // tabPage2
            // 
            this.tabPage2.BackColor = System.Drawing.Color.WhiteSmoke;
            this.tabPage2.Controls.Add(this.comboBoxAlgoritme);
            this.tabPage2.Controls.Add(this.label17);
            this.tabPage2.Controls.Add(this.comboBoxInteger);
            this.tabPage2.Controls.Add(this.textCountPopulate);
            this.tabPage2.Controls.Add(this.textCountGeneration);
            this.tabPage2.Controls.Add(this.textValueMutation);
            this.tabPage2.Controls.Add(this.textChanceMutation);
            this.tabPage2.Controls.Add(this.label13);
            this.tabPage2.Controls.Add(this.countPopulateLabel);
            this.tabPage2.Controls.Add(this.countGenerationLabel);
            this.tabPage2.Controls.Add(this.labelSizeMutation);
            this.tabPage2.Controls.Add(this.labelChanceMutation);
            this.tabPage2.Controls.Add(this.label2);
            this.tabPage2.Location = new System.Drawing.Point(4, 22);
            this.tabPage2.Name = "tabPage2";
            this.tabPage2.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage2.Size = new System.Drawing.Size(1013, 714);
            this.tabPage2.TabIndex = 1;
            this.tabPage2.Text = "Опции";
            // 
            // comboBoxAlgoritme
            // 
            this.comboBoxAlgoritme.FormattingEnabled = true;
            this.comboBoxAlgoritme.Items.AddRange(new object[] {
            "DE-Алгоритм",
            "Классический алгоритм"});
            this.comboBoxAlgoritme.Location = new System.Drawing.Point(553, 359);
            this.comboBoxAlgoritme.Name = "comboBoxAlgoritme";
            this.comboBoxAlgoritme.Size = new System.Drawing.Size(121, 21);
            this.comboBoxAlgoritme.TabIndex = 5;
            this.comboBoxAlgoritme.Text = "DE-Алгоритм";
            this.comboBoxAlgoritme.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.none_KeyPress);
            // 
            // label17
            // 
            this.label17.AutoSize = true;
            this.label17.Location = new System.Drawing.Point(370, 367);
            this.label17.Name = "label17";
            this.label17.Size = new System.Drawing.Size(97, 13);
            this.label17.TabIndex = 4;
            this.label17.Text = "Выбор алгоритма";
            // 
            // comboBoxInteger
            // 
            this.comboBoxInteger.FormattingEnabled = true;
            this.comboBoxInteger.Items.AddRange(new object[] {
            "целочисленное",
            "дробное"});
            this.comboBoxInteger.Location = new System.Drawing.Point(553, 308);
            this.comboBoxInteger.Name = "comboBoxInteger";
            this.comboBoxInteger.Size = new System.Drawing.Size(118, 21);
            this.comboBoxInteger.TabIndex = 3;
            this.comboBoxInteger.Text = "целочисленное";
            this.comboBoxInteger.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.none_KeyPress);
            // 
            // textCountPopulate
            // 
            this.textCountPopulate.Location = new System.Drawing.Point(553, 258);
            this.textCountPopulate.Name = "textCountPopulate";
            this.textCountPopulate.Size = new System.Drawing.Size(57, 20);
            this.textCountPopulate.TabIndex = 2;
            this.textCountPopulate.Text = "100";
            // 
            // textCountGeneration
            // 
            this.textCountGeneration.Location = new System.Drawing.Point(553, 208);
            this.textCountGeneration.Name = "textCountGeneration";
            this.textCountGeneration.Size = new System.Drawing.Size(57, 20);
            this.textCountGeneration.TabIndex = 2;
            this.textCountGeneration.Text = "10";
            // 
            // textValueMutation
            // 
            this.textValueMutation.Location = new System.Drawing.Point(553, 158);
            this.textValueMutation.Name = "textValueMutation";
            this.textValueMutation.Size = new System.Drawing.Size(57, 20);
            this.textValueMutation.TabIndex = 2;
            this.textValueMutation.Text = "0,5";
            // 
            // textChanceMutation
            // 
            this.textChanceMutation.Location = new System.Drawing.Point(553, 107);
            this.textChanceMutation.Name = "textChanceMutation";
            this.textChanceMutation.Size = new System.Drawing.Size(57, 20);
            this.textChanceMutation.TabIndex = 2;
            this.textChanceMutation.Text = "0,6";
            this.textChanceMutation.Leave += new System.EventHandler(this.textChanceMutation_leave);
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.Location = new System.Drawing.Point(370, 313);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(73, 13);
            this.label13.TabIndex = 1;
            this.label13.Text = "Тип решения";
            // 
            // countPopulateLabel
            // 
            this.countPopulateLabel.AutoSize = true;
            this.countPopulateLabel.Location = new System.Drawing.Point(370, 261);
            this.countPopulateLabel.Name = "countPopulateLabel";
            this.countPopulateLabel.Size = new System.Drawing.Size(145, 13);
            this.countPopulateLabel.TabIndex = 1;
            this.countPopulateLabel.Text = "Кол-во особей в популяции";
            // 
            // countGenerationLabel
            // 
            this.countGenerationLabel.AutoSize = true;
            this.countGenerationLabel.Location = new System.Drawing.Point(370, 211);
            this.countGenerationLabel.Name = "countGenerationLabel";
            this.countGenerationLabel.Size = new System.Drawing.Size(98, 13);
            this.countGenerationLabel.TabIndex = 1;
            this.countGenerationLabel.Text = "Кол-во поколений";
            // 
            // labelSizeMutation
            // 
            this.labelSizeMutation.AutoSize = true;
            this.labelSizeMutation.Location = new System.Drawing.Point(370, 161);
            this.labelSizeMutation.Name = "labelSizeMutation";
            this.labelSizeMutation.Size = new System.Drawing.Size(100, 13);
            this.labelSizeMutation.TabIndex = 1;
            this.labelSizeMutation.Text = "Величина мутации";
            // 
            // labelChanceMutation
            // 
            this.labelChanceMutation.AutoSize = true;
            this.labelChanceMutation.Location = new System.Drawing.Point(370, 110);
            this.labelChanceMutation.Name = "labelChanceMutation";
            this.labelChanceMutation.Size = new System.Drawing.Size(117, 13);
            this.labelChanceMutation.TabIndex = 1;
            this.labelChanceMutation.Text = "Вероятность мутации";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label2.Location = new System.Drawing.Point(457, 49);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(69, 24);
            this.label2.TabIndex = 0;
            this.label2.Text = "Опции";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label3.Location = new System.Drawing.Point(465, 30);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(75, 24);
            this.label3.TabIndex = 0;
            this.label3.Text = "Задача";
            // 
            // butReturnResult
            // 
            this.butReturnResult.Location = new System.Drawing.Point(649, 460);
            this.butReturnResult.Name = "butReturnResult";
            this.butReturnResult.Size = new System.Drawing.Size(101, 27);
            this.butReturnResult.TabIndex = 3;
            this.butReturnResult.Text = "Результат";
            this.butReturnResult.UseVisualStyleBackColor = true;
            this.butReturnResult.Click += new System.EventHandler(this.butReturnResult_Click);
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(3, 66);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(90, 13);
            this.label7.TabIndex = 2;
            this.label7.Text = "Вектор решения";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(3, 437);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(202, 13);
            this.label8.TabIndex = 2;
            this.label8.Text = "Значения начальной целевой функции";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(3, 126);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(125, 13);
            this.label9.TabIndex = 2;
            this.label9.Text = "Значения  ограничений";
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Location = new System.Drawing.Point(3, 188);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(146, 13);
            this.label12.TabIndex = 2;
            this.label12.Text = "Значения целевой функции";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label10.Location = new System.Drawing.Point(378, 260);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(268, 24);
            this.label10.TabIndex = 1;
            this.label10.Text = "Промежуточные результаты";
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Location = new System.Drawing.Point(3, 311);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(151, 13);
            this.label11.TabIndex = 2;
            this.label11.Text = "Вектор начального решения";
            // 
            // panelResult
            // 
            this.panelResult.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panelResult.Controls.Add(this.label16);
            this.panelResult.Controls.Add(this.timeBox);
            this.panelResult.Controls.Add(this.label15);
            this.panelResult.Controls.Add(this.butSaveDocument);
            this.panelResult.Controls.Add(this.panelTextsResult2);
            this.panelResult.Controls.Add(this.panelTextsResult);
            this.panelResult.Controls.Add(this.reCalculate);
            this.panelResult.Controls.Add(this.lastButFunction);
            this.panelResult.Controls.Add(this.label6);
            this.panelResult.Controls.Add(this.label10);
            this.panelResult.Controls.Add(this.label7);
            this.panelResult.Controls.Add(this.label14);
            this.panelResult.Controls.Add(this.label11);
            this.panelResult.Controls.Add(this.label8);
            this.panelResult.Controls.Add(this.label12);
            this.panelResult.Controls.Add(this.label9);
            this.panelResult.Location = new System.Drawing.Point(37, 12);
            this.panelResult.Name = "panelResult";
            this.panelResult.Size = new System.Drawing.Size(954, 650);
            this.panelResult.TabIndex = 4;
            // 
            // label16
            // 
            this.label16.AutoSize = true;
            this.label16.Location = new System.Drawing.Point(370, 512);
            this.label16.Name = "label16";
            this.label16.Size = new System.Drawing.Size(69, 13);
            this.label16.TabIndex = 8;
            this.label16.Text = "Милесекунд";
            // 
            // timeBox
            // 
            this.timeBox.Location = new System.Drawing.Point(226, 509);
            this.timeBox.Name = "timeBox";
            this.timeBox.Size = new System.Drawing.Size(138, 20);
            this.timeBox.TabIndex = 3;
            // 
            // label15
            // 
            this.label15.AutoSize = true;
            this.label15.Location = new System.Drawing.Point(3, 512);
            this.label15.Name = "label15";
            this.label15.Size = new System.Drawing.Size(97, 13);
            this.label15.TabIndex = 7;
            this.label15.Text = "Время алгоритма";
            // 
            // butSaveDocument
            // 
            this.butSaveDocument.Location = new System.Drawing.Point(711, 615);
            this.butSaveDocument.Name = "butSaveDocument";
            this.butSaveDocument.Size = new System.Drawing.Size(108, 33);
            this.butSaveDocument.TabIndex = 6;
            this.butSaveDocument.Text = "Сохранить";
            this.butSaveDocument.UseVisualStyleBackColor = true;
            this.butSaveDocument.Click += new System.EventHandler(this.butSaveDocument_Click);
            // 
            // panelTextsResult2
            // 
            this.panelTextsResult2.Controls.Add(this.resultTextFunction2);
            this.panelTextsResult2.Location = new System.Drawing.Point(211, 311);
            this.panelTextsResult2.Name = "panelTextsResult2";
            this.panelTextsResult2.Size = new System.Drawing.Size(698, 157);
            this.panelTextsResult2.TabIndex = 5;
            // 
            // resultTextFunction2
            // 
            this.resultTextFunction2.Location = new System.Drawing.Point(15, 123);
            this.resultTextFunction2.Name = "resultTextFunction2";
            this.resultTextFunction2.Size = new System.Drawing.Size(110, 20);
            this.resultTextFunction2.TabIndex = 3;
            // 
            // panelTextsResult
            // 
            this.panelTextsResult.Controls.Add(this.resultTextFunction);
            this.panelTextsResult.Location = new System.Drawing.Point(211, 66);
            this.panelTextsResult.Name = "panelTextsResult";
            this.panelTextsResult.Size = new System.Drawing.Size(698, 148);
            this.panelTextsResult.TabIndex = 5;
            // 
            // resultTextFunction
            // 
            this.resultTextFunction.Location = new System.Drawing.Point(15, 119);
            this.resultTextFunction.Name = "resultTextFunction";
            this.resultTextFunction.Size = new System.Drawing.Size(110, 20);
            this.resultTextFunction.TabIndex = 3;
            // 
            // reCalculate
            // 
            this.reCalculate.Location = new System.Drawing.Point(844, 614);
            this.reCalculate.Name = "reCalculate";
            this.reCalculate.Size = new System.Drawing.Size(105, 34);
            this.reCalculate.TabIndex = 4;
            this.reCalculate.Text = "Пересчитать";
            this.reCalculate.UseVisualStyleBackColor = true;
            this.reCalculate.Click += new System.EventHandler(this.reCalculate_Click);
            // 
            // lastButFunction
            // 
            this.lastButFunction.Location = new System.Drawing.Point(23, 614);
            this.lastButFunction.Name = "lastButFunction";
            this.lastButFunction.Size = new System.Drawing.Size(105, 34);
            this.lastButFunction.TabIndex = 4;
            this.lastButFunction.Text = "Назад";
            this.lastButFunction.UseVisualStyleBackColor = true;
            this.lastButFunction.Click += new System.EventHandler(this.lastButFunction_Click);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label6.Location = new System.Drawing.Point(442, 15);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(103, 24);
            this.label6.TabIndex = 1;
            this.label6.Text = "Результат";
            // 
            // label14
            // 
            this.label14.AutoSize = true;
            this.label14.Location = new System.Drawing.Point(3, 374);
            this.label14.Name = "label14";
            this.label14.Size = new System.Drawing.Size(151, 13);
            this.label14.TabIndex = 2;
            this.label14.Text = "Вектор начального решения";
            // 
            // butMaxMin
            // 
            this.butMaxMin.Location = new System.Drawing.Point(0, 0);
            this.butMaxMin.Name = "butMaxMin";
            this.butMaxMin.Size = new System.Drawing.Size(121, 21);
            this.butMaxMin.TabIndex = 0;
            // 
            // saveFileDialog
            // 
            this.saveFileDialog.Filter = "(*.doc)|*.doc";
            // 
            // progressBarResult
            // 
            this.progressBarResult.Location = new System.Drawing.Point(37, 662);
            this.progressBarResult.Name = "progressBarResult";
            this.progressBarResult.Size = new System.Drawing.Size(954, 25);
            this.progressBarResult.TabIndex = 5;
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1014, 688);
            this.Controls.Add(this.progressBarResult);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.Fixed3D;
            this.MinimizeBox = false;
            this.Name = "MainForm";
            this.Text = "MainForm";
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.tabControlOption.ResumeLayout(false);
            this.tabPage1.ResumeLayout(false);
            this.panelSolution.ResumeLayout(false);
            this.panelSolution.PerformLayout();
            this.panelFunction.ResumeLayout(false);
            this.panelFunction.PerformLayout();
            this.tabPage2.ResumeLayout(false);
            this.tabPage2.PerformLayout();
            this.panelResult.ResumeLayout(false);
            this.panelResult.PerformLayout();
            this.panelTextsResult2.ResumeLayout(false);
            this.panelTextsResult2.PerformLayout();
            this.panelTextsResult.ResumeLayout(false);
            this.panelTextsResult.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Label resultLabel;
        private System.Windows.Forms.TextBox resultTextBox;
        private System.Windows.Forms.Label vectorSolution;
        private System.Windows.Forms.Label labelFunctionSolution;
        private System.Windows.Forms.TextBox textBoxResultFitness;
        private System.Windows.Forms.Label labelCountRestrict;
        private System.Windows.Forms.TextBox countRestrictText;
        private System.Windows.Forms.Button createFunctionBut;
        private System.Windows.Forms.TextBox countVariableText;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.TabControl tabControlOption;
        private System.Windows.Forms.TabPage tabPage1;
        private System.Windows.Forms.TabPage tabPage2;
        private System.Windows.Forms.TextBox textCountPopulate;
        private System.Windows.Forms.TextBox textCountGeneration;
        private System.Windows.Forms.TextBox textValueMutation;
        private System.Windows.Forms.TextBox textChanceMutation;
        private System.Windows.Forms.Label countPopulateLabel;
        private System.Windows.Forms.Label countGenerationLabel;
        private System.Windows.Forms.Label labelSizeMutation;
        private System.Windows.Forms.Label labelChanceMutation;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Panel panelSolution;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Button buttonCalculate;
        private System.Windows.Forms.Button butLastPage;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.Panel panelResult;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox resultTextFunction;
        private System.Windows.Forms.Label labelCursor;
        private System.Windows.Forms.ComboBox butMaxMin;
        private System.Windows.Forms.ComboBox comboBoxInteger;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.Button lastButFunction;
        private System.Windows.Forms.Button reCalculate;
        private System.Windows.Forms.Panel panelTextsResult;
        private System.Windows.Forms.Panel panelTextsResult2;
        private System.Windows.Forms.TextBox resultTextFunction2;
        private System.Windows.Forms.Label label14;
        private System.Windows.Forms.Button butSaveDocument;
        private System.Windows.Forms.SaveFileDialog saveFileDialog;
        private System.Windows.Forms.Button butReturnResult;
        private System.Windows.Forms.Label label16;
        private System.Windows.Forms.TextBox timeBox;
        private System.Windows.Forms.Label label15;
        private System.Windows.Forms.Panel panelFunctionRestrict;
        private System.Windows.Forms.Panel panelFunction;
        private System.Windows.Forms.ComboBox comboBoxAlgoritme;
        private System.Windows.Forms.Label label17;
        private System.Windows.Forms.ProgressBar progressBarResult;
        
    }
    
}


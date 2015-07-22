using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using core.bl;
using System.IO;
using System.Text.RegularExpressions;

namespace genetic_algorytme
{
    public partial class Form1 : Form, IView
    {
        private int _screenStart = 1;
        private int _screenTask = 2;
        private int _screenResult = 3;

        private int _currentScreen = 1;

        public event EventHandler calculateEvent;
        public event EventHandler saveFileDocument;

        private int _countValueRestrict ;
        private int _countValueVariable ;
        private TextBox[,] _masTextRestrict;
        private TextBox[] _masTextRestrictResult;
        private TextBox[] _masTextFunction;
        private ContainerResult _result;

        private bool _onProgressBar = false;

        private string _saveFileExtension ;
        private ContainerFunction _container;
        private Parametrs _option;
        private ComboBox[] _masTextRestrictSignBut;
        private ContainerResult _intermediateResult;
        private string _saveFile ;
        private const string MESSAGE_EMPTY_TEXT = "Не все поля заполнены!!!";
        private const string MESSAGE_CORRECT_NUM = "Значение полей должны быть числа!!!";
        private const string MESSAGE_EMPTY_OPTION = "Не все опции заданы!!!";
        private const string INPUT_FILE_NAME = "Ввведите название файла";


        public Form1()
        {
            InitializeComponent();
            clearForm();
            createScreenOne();
        
        }



        public string saveFile
        {
            get
            {
                return _saveFile;
            }
        }

   


        public string saveFileExtension
        {
            get
            {
                return _saveFileExtension;
            }
        }


        public ContainerResult result
        {
            set
            {
                _result = value;
                showScreenResult();
            }

            get
            {
                return _result;
            }
               
        }

        public ContainerResult intermediateResult
        {
            set
            {
                _intermediateResult = value;
               
            }

        }

        public Parametrs option
        {
            get
            {
                return _option;
            }

        }

        public ContainerFunction containerFunction
        {
            get
            {
                return _container;
            }

        }

      
        public double getChanceMutation()
        {
            
            return Convert.ToDouble(textChanceMutation.Text.ToString());
        }

        public string getTurnInteger()
        {

            return comboBoxInteger.Text;
        }

        public string getTypeAlgoritme()
        {

            return comboBoxAlgoritme.Text;
        }


        public double getValueMutation()
        {
            
            return Convert.ToDouble(textValueMutation.Text.ToString());

        }

        private int getCountGeneration()
        {
            
            return Convert.ToInt32(textCountGeneration.Text.ToString());              
           
        }

        public int getCountPopulate()
        {
            
            return Convert.ToInt32(textCountPopulate.Text.ToString());
        }    







        //Очитска формы
        private void clearForm()
        {
            this.Controls.Clear();

        }

        //Создание экрана 1
        private void createScreenOne()
        {
            paintScreenOne();
        }


        //Рисование экрана 1
        private void paintScreenOne()
        {
            _currentScreen = _screenStart;
            this.Controls.Add(this.panel1);
            

        }

        //Рисование экрана 2
        private void paintScreenTask()
        {
            clearForm();

            _currentScreen = _screenTask;

            clearControls(panelFunctionRestrict);
            clearControls(panelFunction);
            
            Controls.Add(tabControlOption);

            for (int i = 1; i <= _countValueRestrict; i++)
            {
                for (int j = 1; j <= _countValueVariable; j++)
                {
                    this.panelFunctionRestrict.Controls.Add(_masTextRestrict[i, j]);

                }

                this.panelFunctionRestrict.Controls.Add(_masTextRestrictResult[i]);
                this.panelFunctionRestrict.Controls.Add(_masTextRestrictSignBut[i]);
                
            }

            for (int i = 1; i <= _countValueVariable; i++)
            {
                this.panelFunction.Controls.Add(_masTextFunction[i]);          
            }

            this.panelFunction.Controls.Add(this.labelCursor);
            this.panelFunction.Controls.Add(this.butMaxMin);

            if (_result != null)
                this.tabPage1.Controls.Add(this.butReturnResult);
        }

        //Создание экрана 2
        private void createScreenTask()
        {
            


            int y = 20;
            int x = 10;
            int deltaX = 65;
            int deltaY = 40;


            _masTextRestrict = new TextBox[_countValueRestrict + 1, _countValueVariable + 1];
            _masTextRestrictResult = new TextBox[_countValueRestrict + 1];
            _masTextFunction = new TextBox[_countValueVariable + 1];
            _masTextRestrictSignBut = new ComboBox[_countValueRestrict + 1];
            this.butMaxMin = new ComboBox();
            this.labelCursor = new Label();

            for (int i = 1; i <= _countValueRestrict; i++)
            {
                for (int j = 1; j <= _countValueVariable; j++)
               {
                   _masTextRestrict[i, j] = new TextBox();
                   _masTextRestrict[i, j].Location = new System.Drawing.Point(x + (j - 1) * deltaX, y + (i - 1) * deltaY);
                   _masTextRestrict[i, j].Size = new System.Drawing.Size(40, 20);
            
                   _masTextRestrict[i, j].MaxLength = 7;      
               }

                _masTextRestrictResult[i] = new TextBox();
                _masTextRestrictResult[i].Location = new System.Drawing.Point(x + (_countValueVariable + 1) * deltaX, y + (i - 1) * deltaY);
                _masTextRestrictResult[i].Size = new System.Drawing.Size(40, 20);
                _masTextRestrictResult[i].MaxLength = 9;     

                _masTextRestrictSignBut[i] = new ComboBox();
                _masTextRestrictSignBut[i].Size = new System.Drawing.Size(40, 20);
                _masTextRestrictSignBut[i].Text = staticConst.SIGNLESSEQUALLY;
                _masTextRestrictSignBut[i].Items.Add(staticConst.SIGNLESSEQUALLY);           
                _masTextRestrictSignBut[i].Items.Add(staticConst.SIGNEQUALLY);
                _masTextRestrictSignBut[i].Items.Add(staticConst.SIGNMOREQUALLY);
                _masTextRestrictSignBut[i].KeyPress += new System.Windows.Forms.KeyPressEventHandler(none_KeyPress);
                _masTextRestrictSignBut[i].Location = new System.Drawing.Point(x + (_countValueVariable) * deltaX, y + (i - 1) * deltaY);
           
            }

            deltaY = 10;

            for (int i = 1; i <= _countValueVariable; i++)
            {

                _masTextFunction[i] = new TextBox();
                _masTextFunction[i].Location = new System.Drawing.Point(x + (i - 1) * deltaX, deltaY);

                _masTextFunction[i].Size = new System.Drawing.Size(40, 20);
               
            }

            this.labelCursor.Location = new System.Drawing.Point(x + (_countValueVariable) * deltaX, deltaY);
            this.labelCursor.Size = new System.Drawing.Size(60, 20);
            this.butMaxMin.Location = new System.Drawing.Point(x + (_countValueVariable + 1) * deltaX, deltaY);
            this.butMaxMin.Size = new System.Drawing.Size(40, 20);
            this.butMaxMin.Name = "butMaxMin";
            this.butMaxMin.KeyPress += new System.Windows.Forms.KeyPressEventHandler(none_KeyPress);
            this.butMaxMin.Text = staticConst.SIGNMAX;
            this.butMaxMin.Items.Add(staticConst.SIGNMAX);
            this.butMaxMin.Items.Add(staticConst.SIGNMIN);

 
        }


        
        #region Блок валидации вводимых данных

        //Запрет ввод с клавиатуры
        private void none_KeyPress(object sender, KeyPressEventArgs e)
        {
            e.Handled = true;
        }

 

        //Ограничение значения от 0.0 до 1.0
        private void textChanceMutation_leave(object sender, System.EventArgs e)
        {
            
            TextBox textBox = (TextBox)sender;
            double value = Convert.ToDouble(textBox.Text) ;
       
            if ((value < 0 ) || (value > 1))
            {
                textBox.Text = "0,6" ;
                MessageBox.Show("Некорректное значение вероятности мутации!!!");
            }
          
        }

        //Валидация целых чисел
        private bool validateInt(string text)
        {
            string pattern = "^([0-9]|-[0-9])+$";
             Match match = Regex.Match(text, pattern);
             return match.Success;

        }

        //Валидация дробных чисел
        private bool validateDouble(string text)
        {
      
            string pattern = "^([0-9]|-[0-9])+([0-9]*|,[0-9])[0-9]*$";
            Match match = Regex.Match(text, pattern);
            return match.Success;
        }



    
        #endregion


        private void clearControls(Panel pnl)
        {
            Control tempRef;
            for (int i = pnl.Controls.Count - 1; i >= 0; i--)
            {
                tempRef = pnl.Controls[i];           
                pnl.Controls.RemoveAt(i);
                
            }
        }
        


        //Считывание ограничений и функции
        private bool readOption()
        {
            if (textChanceMutation.Text == "" || textValueMutation.Text == "" || textCountGeneration.Text == "")
            {

                MessageBox.Show(MESSAGE_EMPTY_OPTION);
                return false;
            }

            if (!(validateDouble(textChanceMutation.Text)) || !(validateDouble(textValueMutation.Text)) || !(validateInt(textCountGeneration.Text)))
            {
                MessageBox.Show(MESSAGE_CORRECT_NUM);
                return false;
            }

            _option = new Parametrs();
            _option.countGeneration = getCountGeneration();
            _option.countPopulate = getCountPopulate();
            _option.countValueVariable = _countValueVariable;
            _option.valueMutation = getValueMutation();
            _option.сhanceMutation = getChanceMutation();
            _option.turnInteger = getTurnInteger();
            _option.typeAlgoritme = getTypeAlgoritme();

            return true;
        }

        private bool readMassive()
        {
            _container = new ContainerFunction();


            for (int i = 1; i <= _countValueRestrict; i++)
            {
                MatrixItem item = new MatrixItem();

                for (int j = 1; j <= _countValueVariable; j++)
                {
                    if (_masTextRestrict[i, j].Text == "")
                    {
                        MessageBox.Show(MESSAGE_EMPTY_TEXT);
                        return false;
                    }

                    if (!(validateDouble(_masTextRestrict[i, j].Text)))
                    {
                        MessageBox.Show(MESSAGE_CORRECT_NUM);
                        return false;
                    }

                    item.addItem(Convert.ToDouble(_masTextRestrict[i, j].Text));
                    item.Sign = _masTextRestrictSignBut[i].Text;
                        
                    
                }

               

                if (_masTextRestrictResult[i].Text == "")
                {
                    MessageBox.Show(MESSAGE_EMPTY_TEXT);
                    return false;
                }

                if (!(validateDouble(_masTextRestrictResult[i].Text)))
                {
                    MessageBox.Show(MESSAGE_CORRECT_NUM);
                    return false;
                }

                item.restriction = Convert.ToDouble(_masTextRestrictResult[i].Text);
          

                _container.matrix.Add(item);
            }

            for (int i = 1; i <= _countValueVariable; i++)
            {
                if (_masTextFunction[i].Text == "")
                {
                    MessageBox.Show(MESSAGE_EMPTY_TEXT);
                    return false;
                }

                if (!(validateDouble(_masTextFunction[i].Text)))
                {
                    MessageBox.Show(MESSAGE_EMPTY_TEXT);
                    return false;
                }

                _container.fitness.Add(Convert.ToDouble(_masTextFunction[i].Text));
               
            }


            _container.cursor = this.butMaxMin.Text ;
            return true;
        }

        //Показать результат
        private void showScreenResult()
        {
            _currentScreen = _screenResult;

            clearForm();

            clearControls(this.panelTextsResult);
            clearControls(this.panelTextsResult2);
          
            if (_result != null)
            {

                int deltaX = 15;
                int deltaY = 0;
                this.Controls.Add(this.panelResult);

                this.textBoxResultFitness.Text = _result.fitness.ToString();

                int i = 0;
                foreach(int vect in _result.vector)
                {

                    TextBox textBox = new TextBox() ;
                    textBox.Location = new System.Drawing.Point(deltaX + i * 70, deltaY);
                    textBox.Size = new System.Drawing.Size(60, 20);
                  
    
                    textBox.Text = vect.ToString();

                    this.panelTextsResult.Controls.Add(textBox);
                    i++;
                }

                resultTextFunction.Text = _result.realResult.ToString();

                this.panelTextsResult.Controls.Add(resultTextFunction);

                deltaX = 15;
                deltaY = 55;

                i = 0;
                foreach (int vect in _result.realRestrict)
                {
                    
                    TextBox textBox = new TextBox();
                    textBox.Location = new System.Drawing.Point(deltaX + i * 70, deltaY);
                    textBox.Size = new System.Drawing.Size(60, 20);
                    textBox.Text = vect.ToString();
                    this.panelTextsResult.Controls.Add(textBox);
                    i++;
                }
            }


            if (_intermediateResult != null)
            {

                int deltaX = 15;
                int deltaY = 0;

                int i = 0;
                foreach (int vect in _intermediateResult.vector)
                {

                    TextBox textBox = new TextBox();
                    textBox.Location = new System.Drawing.Point(deltaX + i * 70, deltaY);
                    textBox.Size = new System.Drawing.Size(60, 20);


                    textBox.Text = vect.ToString();

                    this.panelTextsResult2.Controls.Add(textBox);
                    i++;
                }

                deltaX = 15;
                deltaY = 55;

                i = 0;

                foreach (int vect in _intermediateResult.realRestrict)
                {

                    TextBox textBox = new TextBox();
                    textBox.Location = new System.Drawing.Point(deltaX + i * 70, deltaY);
                    textBox.Size = new System.Drawing.Size(60, 20);
                    textBox.Text = vect.ToString();
                    this.panelTextsResult2.Controls.Add(textBox);
                    i++;
                }

                resultTextFunction2.Text = _intermediateResult.realResult.ToString();
                timeBox.Text = _result.time.ToString();
                this.panelTextsResult2.Controls.Add(resultTextFunction2);

            }

        }
    
    

        private void nextBut_Click(object sender, EventArgs e)
        {

            if (this.countRestrictText.Text == "" || this.countVariableText.Text == "")
            {
                MessageBox.Show(MESSAGE_EMPTY_TEXT);
                return;
            }

            if (!validateInt(this.countRestrictText.Text) || !validateInt(this.countVariableText.Text))
            {
                MessageBox.Show(MESSAGE_CORRECT_NUM);
                return;
            }


            int countValueTextRestrict = Convert.ToInt32(this.countRestrictText.Text);
            int countValueVariableText = Convert.ToInt32(this.countVariableText.Text);

            if (countValueTextRestrict != _countValueRestrict || countValueVariableText != _countValueVariable)
            {
                _countValueRestrict = countValueTextRestrict;
                _countValueVariable = countValueVariableText;
                createScreenTask();
            }
            

            clearForm();
            paintScreenTask();
        }

        private void butLastPage_Click(object sender, EventArgs e)
        {
            clearForm();
            createScreenOne();
        }



       

        //Событие рассчета задачи
        private void buttonCalculate_Click(object sender, EventArgs e)
        {
  
            if (!readMassive() || !readOption())
            {
                return;
            }

            if (calculateEvent != null)
                calculateEvent(this, EventArgs.Empty);
            


        }


        #region Прогресс бар 

        //Показ прогресс бара
        public void showProgress(int length, int step)
        {

            
            if (_onProgressBar == false)
            {
                 clearForm();
                 this.Controls.Add(this.progressBarResult);
                 progressBarResult.Visible = true;
                 progressBarResult.Minimum = 1;
                 progressBarResult.Maximum = length;
                 progressBarResult.Value = 1;
                 progressBarResult.Step = 1;

                _onProgressBar = true;

            }

            progressBarResult.PerformStep();

            if (step == length) 
            {
                _onProgressBar = false;
                progressBarResult.Refresh();    
            }        
        }


        #endregion

        private void reCalculate_Click(object sender, EventArgs e)
        {
            if (calculateEvent != null)
                calculateEvent(this, EventArgs.Empty);
        }

        private void lastButFunction_Click(object sender, EventArgs e)
        {
            paintScreenTask();
        }

        private void butSaveDocument_Click(object sender, EventArgs e)
        {
            saveFileDialog.ShowDialog();

            if (saveFileDialog.FileName == "")
            {
                MessageBox.Show(INPUT_FILE_NAME);
                return;
            }
            
            _saveFile = saveFileDialog.FileName;
            _saveFileExtension = Path.GetExtension(saveFileDialog.FileName); 

            if (saveFileDocument != null)
                saveFileDocument(this, EventArgs.Empty);
            
            
        }

        private void butReturnResult_Click(object sender, EventArgs e)
        {
            showScreenResult();
        }
    }
}

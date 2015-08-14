using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace VocabularyTest
{
    public partial class VocabularyTestView : Form
    {
        private VocabularyPresentationModel _presentationMode;
        AboutSpallingCheckerView _aboutSpallingCheckerView = new AboutSpallingCheckerView();
        private const int MILLISECONDS_PER_SECOND = 1000; //每秒為1000毫秒
        private Timer _timer = new Timer(); //計時器
        private int _selectIndex = 0;
        private void StartTimer() //開始計時
        {
            _timer.Start();//開始計時
            _timeProgressBar.Step = _presentationMode.ProcessBarStep;
        }

        private void RestTimer() //重設計數器
        {
            _timer.Stop(); //暫停計數
            _presentationMode.RsetTimer(); //清除計時器
            _timeProgressBar.Value = 0; //進度條歸零
        }

        private void TickEventHandler(object sender, EventArgs e) //開始計時的動作
        {
            const string TIME_OUT = "TIME OUT!!";
            const string EMPTY = "";
            _timeProgressBar.PerformStep();
            _presentationMode.RunTimer();
            _timeLabel.Text = _presentationMode.TimeLabelText;
            if (_presentationMode.IsTimeUp)
            {
                _answerTextBox.Text = EMPTY;
                _selectIndex = 0;
                _nextButton.PerformClick();
                _toolStripStatusLabel.Text = TIME_OUT + _toolStripStatusLabel.Text;
            }
        }

        private void LoadAllElement()  //載入各項元素
        {
            LoadButtonsEnabled();
            LoadLabelsText();
            LoadRadioButtonsText();
            LoadToolStripMenuItems();
            LoadTableLayoutPanelsVisible();
            _answerTextBox.Enabled = _presentationMode.IsAnswerTextBoxEnabled;
            _answerTextBox.Text = _presentationMode.AnswerTextBoxText;
            _questionGroupBox.Text = _presentationMode.QuestionGroupBoxText;
            this.Size = _presentationMode.FormSize;
            UnCheckAllRadioButton();
        }

        private void LoadToolStripMenuItems() //載入各個ToolStripMenuItems
        {
            _startToolStripMenuItem.Enabled = _presentationMode.StartToolStripMenuItemEnabled;
            _nextToolStripMenuItem.Enabled = _presentationMode.NextTooStripMenuItemEnabled;
            _stopToolStripMenuItem.Enabled = _presentationMode.StopTooStripMenuItemEnabled;
            _allFillInTheBlankQuestionsToolStripMenuItem.Enabled = _presentationMode.AllFillInTheBlankQuestionsToolStripMenuItemEnabled;
            _allListeningComprehensionMultipleChoiceQuestionsToolStripMenuItem.Enabled = _presentationMode.AllListeningComprehensionMultipleChoiceQuestionsToolStripMenuItemEnabled;
            _pickUpQuestionsRndomlyToolStripMenuItem.Enabled = _presentationMode.PickUpQuestionsRandomlyToolStripMenuItemEnabled;
            _allFillInTheBlankQuestionsToolStripMenuItem.Checked = _presentationMode.AllFillInTheBlankQuestionsToolStripMenuItemChecked;
            _allListeningComprehensionMultipleChoiceQuestionsToolStripMenuItem.Checked = _presentationMode.AllListeningComprehensionMultipleChoiceQuestionsToolStripMenuItemChecked;
            _pickUpQuestionsRndomlyToolStripMenuItem.Checked = _presentationMode.PickUpQuestionsRandomlyToolStripMenuItemChecked;
        }

        private void LoadTableLayoutPanelsVisible() //載入各個TableLayoutPanelsVisible
        {
            _fillQuestionTableLayoutPanel.Visible = _presentationMode.IsFillQuestionTableLayoutPanelVisiabled;
            _selectionQuestionTableLayoutPanel.Visible = _presentationMode.IsSelectionQuestionTableLayoutPanelVisabled;
            _chooseNumberOfQuesiontTableLayoutPanel.Visible = _presentationMode.IsChooseNumberOfQuestionLayoutPanelVisiabled;
        }

        private void LoadLabelsText()//載入各個LabelsText
        {
            _questionLabel.Text = _presentationMode.QuestionLabelText;
            _toolStripStatusLabel.Text = _presentationMode.StatusBarText;
            _timeLabel.Text = _presentationMode.TimeLabelText;

        }

        private void LoadRadioButtonsText()//載入各個RadioButtonsText
        {
            _firstSelectionRadioButton.Text = _presentationMode.FirstRadioButtonText;
            _secondSelectionRadioButton.Text = _presentationMode.SecondRadioButtonText;
            _thirdSelectionRadioButton.Text = _presentationMode.ThirdRadioButtonText;
            _fourthRadioButton.Text = _presentationMode.FourthRadioButtonText;
        }

        private void LoadButtonsEnabled()//載入各個ButtonsEnabled
        {
            _startButton.Enabled = _presentationMode.IsStartButtonEnabled;
            _stopButton.Enabled = _presentationMode.IsStopButtonEnabled;
            _nextButton.Enabled = _presentationMode.IsNextButtonEnabled;
        }

        public void UnCheckAllRadioButton()//取消每個RadioButton選取狀態
        {
            _firstSelectionRadioButton.Checked = false;
            _secondSelectionRadioButton.Checked = false;
            _thirdSelectionRadioButton.Checked = false;
            _fourthRadioButton.Checked = false;
            _selectIndex = 0;
        }

        public void Initialize() //初始化
        {
            const int NUMBER_OF_ROW = 4;  
            const int THIRD_ROW = 3;
            _viewTableLayoutPanel.RowCount = NUMBER_OF_ROW; //設為4列
            _viewTableLayoutPanel.Controls.Remove(_timeLabel); //將時間Label從viewTableLayoutPanel刪除
            _viewTableLayoutPanel.Controls.Remove(_timeProgressBar);//將時間條從viewTableLayoutPanel刪除
            _viewTableLayoutPanel.SetRow(_vocabularyTestStatusStrip, THIRD_ROW);//將狀態列往上移
            _questionTypeComboBox.SelectedIndex = 0;//預設COMBOX選擇第0項
            _questionTypeToolStripMenuItem.Enabled = true; 
            _numberOfQuestionToolStripMenuItem.Enabled = true;
            _reminTimeToolStripStatusLabel.Visible = false;
            RestTimer();
            //UnCheckAllRadioButton();
        }

        public void ClickTenQuestion(object sender, EventArgs e) //按下10 Question的動作
        {
            const int TEN = 10;
            _numberOfQuestionNumericUpDown.Value = TEN;
        }

        public void ClickTwentyQuestion(object sender, EventArgs e)//按下20 Question的動作
        {
            const int TWENTY = 20;
            _numberOfQuestionNumericUpDown.Value = TWENTY;
        }

        public void ClickFiftyQuestion(object sender, EventArgs e)//按下50 Question的動作
        {
            const int FIFTY = 50;
            _numberOfQuestionNumericUpDown.Value = FIFTY;
        }

        public void ClickAboutSpellingChecker(object sender, EventArgs e)//按下AboutSpellingChecker的動作
        {
            _aboutSpallingCheckerView.ShowDialog();
        }

        public VocabularyTestView(VocabularyPresentationModel presentationModel)//建構元
        {
            this._presentationMode = presentationModel;
            _timer.Interval = MILLISECONDS_PER_SECOND; //每1000毫秒觸發一次事件
            _timer.Tick += TickEventHandler;//加入事件
            InitializeComponent(); //初始化
            LoadAllElement(); //載入各項元素
            Initialize();//初始化
        }

        public void ClickAboutDictionaryToolStripMenuItem(object sender, EventArgs e) //按下AboutDictionary的動作
        {
            MessageBox.Show(_presentationMode.AboutDictionaryMessageBoxText);
        }

        public void ClickAllFillInTheBlankQuestionsToolStripMenuItem(object sender, EventArgs e)//按下AllFillInTheBlankQuestions的動作
        {
            _presentationMode.PressAllFillInTheBlankQuestionsToolStripMenuItem();
            LoadAllElement();
            _questionTypeComboBox.SelectedIndex = 0;
        }

        public void ClickAllListeningComprehensionMultipleChoiceQuestionsToolStripMenuItem(object sender, EventArgs e)//按下ListeningComprehensionMultipleChoiceQuestions的動作
        {
            _presentationMode.PressAllListeningComprehensionMultipleChoiceQuestionsToolStripMenuItem();
            LoadAllElement();
            _questionTypeComboBox.SelectedIndex = 1;
        }

        public void ClickPickUpQuestionsRndomlyToolStripMenuItem(object sender, EventArgs e)//按下PickUpQuestionsRndomly的動作
        {
            const int TYPE_INDEX = 2;
            _presentationMode.PressPickUpQuestionsRndomlyToolStripMenuItem();
            LoadAllElement();
            _questionTypeComboBox.SelectedIndex = TYPE_INDEX;
        }

        public void ClickExitToolStripMenuItem(object sender, EventArgs e)//按下Exit的動作
        {
            this.Close();
        }

        public void PressListenButton(object sender, EventArgs e) //按下Listen按鈕
        {
            _presentationMode.PressListenButton();
        }

        public void PressStartButton(object sender, EventArgs e) //按下Start按鈕
        {
            const int NUMBER_OF_ROW = 5;
            const int FOURTH_ROW = 4;
            const int THIRD_ROW = 3;
            _presentationMode.PressStartButton((int)_numberOfQuestionNumericUpDown.Value, _questionTypeComboBox.SelectedIndex);
            StartTimer();
            LoadAllElement();
            _viewTableLayoutPanel.RowCount = NUMBER_OF_ROW;
            _viewTableLayoutPanel.Controls.Add(_timeLabel, 0, THIRD_ROW);
            _viewTableLayoutPanel.Controls.Add(_timeProgressBar, 1, THIRD_ROW);
            _viewTableLayoutPanel.SetRow(_vocabularyTestStatusStrip, FOURTH_ROW);
            _numberOfQuestionToolStripMenuItem.Enabled = false;
            _questionTypeToolStripMenuItem.Enabled = false;
            _reminTimeToolStripStatusLabel.Visible = true;
        }

        public void PressNextButton(object sender, EventArgs e) //按下Next按鈕
        {
            _presentationMode.PressNextButton(_answerTextBox.Text, _selectIndex);
            UnCheckAllRadioButton();
            RestTimer();
            StartTimer();
            LoadAllElement();//載入各個元素
            if (!_presentationMode.IsStartTest) //若測驗結束，顯示MessageBox
            {
                _timer.Dispose();
                Initialize();
                MessageBox.Show(_presentationMode.MessageBoxText);
            }
        }

        private void PressFirstSelectRadioItem(object sender, EventArgs e)
        {
            const int ONE = 1;
            _selectIndex = ONE;
        }

        private void PressSecondSelectRadioItem(object sender, EventArgs e)
        {
            const int TWO = 2;
            _selectIndex = TWO;
        }

        private void PressThirdSelectionRadioItem(object sender, EventArgs e)
        {
            const int THREE = 3;
            _selectIndex = THREE;
        }

        private void PressFourSelectionRadioItem(object sender, EventArgs e)
        {
            const int FOUR = 4;
            _selectIndex = FOUR;
        }

        private void PressStopButton(object sender, EventArgs e) //按下STOP按鈕
        {
            _presentationMode.PressStopButton(_answerTextBox.Text, _selectIndex);
            LoadAllElement();
            Initialize();
            MessageBox.Show(_presentationMode.MessageBoxText);
        }

        private void QuestionTypeComboBoxSelectedIndexChanged(object sender, EventArgs e) //QuestionTypeComboBox選擇的INDEX改變所做的動作
        {
            _presentationMode.ChangedQuestionTypeComboBoxSelectedIndex(_questionTypeComboBox.SelectedIndex);
            LoadAllElement();
        }
    }
}

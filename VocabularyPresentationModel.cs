using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace VocabularyTest
{
    public class VocabularyPresentationModel
    {
        const int DEAD_LINE_IN_SECOND = 20;  //截止秒數
        const string DEAD_LINE = "00:00:20"; //截止時間
        const string EMPTY = ""; //空字串
        const string CORRECT = "Correct!!"; //回答正確顯示字串
        const string ANSWER_FAIL = "It should be "; //回答錯誤前段字串
        const string RIGHT_BRACKETS = ")"; //右括號
        const string LEFT_BRACKETS = "("; //左括號
        const string PERCENTAGE_SYMBOLE = "%"; //百分比符號
        const string SCORE_CHINESE = "得分: ";//得分中文
        const string LEFT_DIAGONAL = "/";//左斜線
        const string BLANK = " ";//空白
        const string DOUBLE_SHOW_FORMAT = "F0";//DOUBLE顯示格式
        const string QUESTION_ABBREVIATION = "Q";//Question 縮寫
        const string FILL_QUESTION_TIP = ": Fill in the Blanks"; //填充填題目說明
        const string SELECTION_QUESTION_TIP = ":Listehning Comprehension Multiple Choice Question";//選擇題題目說明
        const string CHOOSE_NUMBER_OF_QUESTION_TIP = "Customize Your Examination";       //選擇考試題數說明
        const string ABOUT_DICTIONARY_MESSAGEBOX_TEXT_INFRONT_OF_INTS = "Total";          //顯示關於字典檔的前段提示
        const string ABOUT_DICTIONARY_MESSAGEBOX_TEXT_BEHIND_OF_INTS = "words in the dictionary.";//顯示關於字典檔的後段提示
        private List<string> _selection; //選擇題的選項占存
        private string _previousFillQuestionAnswer = string.Empty;
        private int _previousSelectionAnswer = 0;
        private bool _isStartTest = false;  //是否已開始測驗
        private bool _isStartButtonEnabled = true;  //Start按鈕ENABLE狀態
        private bool _isNextButtonEnabled = false;  //Next按鈕ENABLE狀態
        private bool _isStopButtonEnabled = false; //stop按鈕狀態
        private bool _isAnswerTextBoxEnabled = false;//AnsweTextbo ENABLE狀態
        private bool _isChooseNumberOfQuestionLayoutPanelVisiabled = true; //選擇題數視窗顯示狀態
        private bool _isFillQuestionTableLayoutPanelVisiabled = false;//填充題顯示狀態
        private bool _isSelectionQuestionTableLayoutPanelVisabled = false;//選擇題顯示狀態
        private bool _allListeningComprehensionMultipleChoiceQuestionsToolStripMenuItemChecked = false; //allListeningcomprehensionmultiplechoiceQuestions工具列選項有無打勾狀態
        private bool _allListeningComprehensionMultipleChoiceQuestionsToolStripMenuItemEnabled = true; //allFillInTheBlankQuestions工具列選項Enable狀態
        private bool _pickUpQuestionsRandomlyToolStripMenuItemChecked = true; //pickUpQuestionsRndomly工具列選項有無打勾狀態
        private bool _pickUpQuestionsRandomlyToolStripMenuItemEnabled = false;//pickUpQuestionsRndomly工具列選項Enable狀態
        private bool _allFillInTheBlankQuestionsToolStripMenuItemChecked = false; //allFillInTheBlankQuestions工具列選項有無打勾狀態
        private bool _allFillInTheBlankQuestionsToolStripMenuItemEnabled = true;  //allFillInTheBlankQuestions工具列選項Enable狀態
        private bool _startToolStripMenuItemEnabled = true; //Start工具列選項Enable狀態
        private bool _nextToolStripMenuItemEnabled = false; //Next工具列選項Enable狀態 
        private bool _stopToolStripMenuItemEnabled = false; //Stop工具列選項Enable狀態 
        private string _questionLabelText = EMPTY;//題目標籤
        private string _answerTextBoxText = EMPTY;//回答欄文字
        private string _statusBarText = EMPTY;//狀態列文字
        private string _messageBoxText = EMPTY;//MessageBox顯示文字
        private string _firstRadioButtonText = EMPTY;//選項1文字
        private string _secondRadioButtonText = EMPTY;//選項2文字
        private string _thirdRadioButtonText = EMPTY;//選項3文字
        private string _fourthRadioButtonText = EMPTY;//選項4文字
        private string _questionGroupBoxText = EMPTY; //顯示動作提示文字
        private VocabularyMode _vocabularyMode;//宣告 Model
        private bool _isTimeUp = false; //Timeout 旗標
        public int ProcessBarStep//進度條每次進度
        {
            get
            {
                const int PROGRESS_BAR_MAX_VALUE = 100; //進度條最大值
                return PROGRESS_BAR_MAX_VALUE / DEAD_LINE_IN_SECOND;//算出進度條每次增加量
            }
        }

        public bool IsTimeUp
        {
            get
            {
                return _isTimeUp;
            }
        }

        public string TimeLabelText
        {
            get
            {
                return _vocabularyMode.TimeText;
            }
        }


        public bool IsStartTest
        {
            get
            {
                return _isStartTest;
            }
        }

        public bool IsStartButtonEnabled
        {
            get
            {
                return _isStartButtonEnabled;
            }
        }

        public bool IsStopButtonEnabled
        {
            get
            {
                return _isStopButtonEnabled;
            }
        }

        public bool IsNextButtonEnabled
        {
            get
            {
                return _isNextButtonEnabled;
            }
        }

        public bool IsAnswerTextBoxEnabled
        {
            get
            {
                return _isAnswerTextBoxEnabled;
            }
        }

        public bool IsFillQuestionTableLayoutPanelVisiabled
        {
            get
            {
                return _isFillQuestionTableLayoutPanelVisiabled;
            }
        }

        public bool IsSelectionQuestionTableLayoutPanelVisabled
        {
            get
            {
                return _isSelectionQuestionTableLayoutPanelVisabled;
            }
        }

        public bool IsChooseNumberOfQuestionLayoutPanelVisiabled
        {
            get
            {
                return _isChooseNumberOfQuestionLayoutPanelVisiabled;
            }
        }

        public string QuestionLabelText
        {
            get
            {
                return _questionLabelText;
            }
        }

        public string AnswerTextBoxText
        {
            get
            {
                return _answerTextBoxText;
            }
        }

        public string StatusBarText
        {
            get
            {
                return _statusBarText;
            }
        }

        public string MessageBoxText
        {
            get
            {
                return _messageBoxText;
            }
        }

        public string FirstRadioButtonText
        {
            get
            {
                return _firstRadioButtonText;
            }
        }

        public string SecondRadioButtonText
        {
            get
            {
                return _secondRadioButtonText;
            }
        }

        public string ThirdRadioButtonText
        {
            get
            {
                return _thirdRadioButtonText;
            }
        }

        public string FourthRadioButtonText
        {
            get
            {
                return _fourthRadioButtonText;
            }
        }

        public string QuestionGroupBoxText
        {
            get
            {
                return _questionGroupBoxText;
            }
        }

        public bool AllFillInTheBlankQuestionsToolStripMenuItemChecked
        {
            get
            {
                return _allFillInTheBlankQuestionsToolStripMenuItemChecked;
            }
        }

        public bool AllFillInTheBlankQuestionsToolStripMenuItemEnabled
        {
            get
            {
                return _allFillInTheBlankQuestionsToolStripMenuItemEnabled;
            }
        }

        public bool AllListeningComprehensionMultipleChoiceQuestionsToolStripMenuItemChecked
        {
            get
            {
                return _allListeningComprehensionMultipleChoiceQuestionsToolStripMenuItemChecked;
            }
        }

        public bool AllListeningComprehensionMultipleChoiceQuestionsToolStripMenuItemEnabled
        {
            get
            {
                return _allListeningComprehensionMultipleChoiceQuestionsToolStripMenuItemEnabled;
            }
        }

        public bool PickUpQuestionsRandomlyToolStripMenuItemChecked
        {
            get
            {
                return _pickUpQuestionsRandomlyToolStripMenuItemChecked;
            }
        }

        public bool PickUpQuestionsRandomlyToolStripMenuItemEnabled
        {
            get
            {
                return _pickUpQuestionsRandomlyToolStripMenuItemEnabled;
            }
        }

        public bool StartToolStripMenuItemEnabled
        {
            get
            {
                return _startToolStripMenuItemEnabled;
            }
        }

        public bool StopTooStripMenuItemEnabled
        {
            get
            {
                return _stopToolStripMenuItemEnabled;
            }
        }

        public bool NextTooStripMenuItemEnabled
        {
            get
            {
                return _nextToolStripMenuItemEnabled;
            }
        }

        public void RunTimer()
        {
            _vocabularyMode.AddOneSecond();
            if (_vocabularyMode.TimeText == DEAD_LINE)
                _isTimeUp = true;
        }

        public void RsetTimer()
        {
            _vocabularyMode.RestTimer();
            _isTimeUp = false;
        }

        private void Initialize()  //初始化
        {
            InitializeToolStripMenuItems();
            _isStartButtonEnabled = true;
            _isNextButtonEnabled = false;
            _isStopButtonEnabled = false;
            _isAnswerTextBoxEnabled = false;
            _isStartButtonEnabled = true;
            _isChooseNumberOfQuestionLayoutPanelVisiabled = true;
            _isFillQuestionTableLayoutPanelVisiabled = false;
            _isSelectionQuestionTableLayoutPanelVisabled = false;
            _questionLabelText = EMPTY;
            _answerTextBoxText = EMPTY;
            _firstRadioButtonText = EMPTY;
            _secondRadioButtonText = EMPTY;
            _thirdRadioButtonText = EMPTY;
            _fourthRadioButtonText = EMPTY;
            _questionGroupBoxText = CHOOSE_NUMBER_OF_QUESTION_TIP;
            RsetTimer();
        }

        private void UnCheckAndEnableAllQuestionTypeSubtManuItem()
        {
            _allListeningComprehensionMultipleChoiceQuestionsToolStripMenuItemChecked = false;
            _allFillInTheBlankQuestionsToolStripMenuItemChecked = false;
            _pickUpQuestionsRandomlyToolStripMenuItemChecked = false;
            _allListeningComprehensionMultipleChoiceQuestionsToolStripMenuItemEnabled = true;
            _pickUpQuestionsRandomlyToolStripMenuItemEnabled = true;
            _allFillInTheBlankQuestionsToolStripMenuItemEnabled = true;
        }

        private void InitializeToolStripMenuItems()  //所有 ToolStripMenuItem 物件初始化
        {
            _startToolStripMenuItemEnabled = true;
            _stopToolStripMenuItemEnabled = false;
            _nextToolStripMenuItemEnabled = false;
        }

        public void ChangedQuestionTypeComboBoxSelectedIndex(int selectIndex)//當QuestionTypeComboBox被選到的索引植有改變時的動作
        {
            if (selectIndex == 0) //若被選取的索引位置在 0  等同於按下 PressAllFillInTheBlankQuestionsToolStripMenuItem
                PressAllFillInTheBlankQuestionsToolStripMenuItem();
            else if (selectIndex == 1) //若被選取的索引位置在1 等同於按下PressAllListeningComprehensionMultipleChoiceQuestionsToolStripMenuItem 
                PressAllListeningComprehensionMultipleChoiceQuestionsToolStripMenuItem();
            else //若皆不是 表示索引位置在2 等同於按下PressPickUpQuestionsRndomlyToolStripMenuItem
                PressPickUpQuestionsRndomlyToolStripMenuItem();
        }

        public void PressPickUpQuestionsRndomlyToolStripMenuItem()
        {
            UnCheckAndEnableAllQuestionTypeSubtManuItem();
            _pickUpQuestionsRandomlyToolStripMenuItemChecked = true;
            _pickUpQuestionsRandomlyToolStripMenuItemEnabled = false;
        }

        public void PressAllListeningComprehensionMultipleChoiceQuestionsToolStripMenuItem()
        {
            UnCheckAndEnableAllQuestionTypeSubtManuItem();
            _allListeningComprehensionMultipleChoiceQuestionsToolStripMenuItemChecked = true;
            _allListeningComprehensionMultipleChoiceQuestionsToolStripMenuItemEnabled = false;
        }

        public void PressAllFillInTheBlankQuestionsToolStripMenuItem()
        {
            UnCheckAndEnableAllQuestionTypeSubtManuItem();
            _allFillInTheBlankQuestionsToolStripMenuItemChecked = true;
            _allFillInTheBlankQuestionsToolStripMenuItemEnabled = false;
        }

        public VocabularyPresentationModel(VocabularyMode vocabularyModes) //建構元
        {
            this._vocabularyMode = vocabularyModes;
            _vocabularyMode.Initialize();
            Initialize();
        }

        private void ProcessSelectionQuestion()//選擇題處理工作
        {
            const int ADDRESS_ZERO = 0; //位置0
            const int ADDRESS_ONE = 1;  //位置1
            const int ADDRESS_TWO = 2;  //位置2
            const int ADDRESS_THREE = 3;//位置3
            _questionGroupBoxText = QUESTION_ABBREVIATION + (_vocabularyMode.NumberOfAnswered + 1).ToString() + SELECTION_QUESTION_TIP;//選擇題題目說明
            _selection = _vocabularyMode.CreateNewSelectionQuestion();//產生新題目
            _firstRadioButtonText = LEFT_BRACKETS + (ADDRESS_ZERO + 1).ToString() + RIGHT_BRACKETS + BLANK + _selection[ADDRESS_ZERO]; //設定選項1
            _secondRadioButtonText = LEFT_BRACKETS + (ADDRESS_ONE + 1).ToString() + RIGHT_BRACKETS + BLANK + _selection[ADDRESS_ONE];  //設定選項2
            _thirdRadioButtonText = LEFT_BRACKETS + (ADDRESS_TWO + 1).ToString() + RIGHT_BRACKETS + BLANK + _selection[ADDRESS_TWO];   //設定選項3
            _fourthRadioButtonText = LEFT_BRACKETS + (ADDRESS_THREE + 1).ToString() + RIGHT_BRACKETS + BLANK + _selection[ADDRESS_THREE]; //設定選項4
            _isFillQuestionTableLayoutPanelVisiabled = false; //不顯示填充題
            _isSelectionQuestionTableLayoutPanelVisabled = true; //顯示選擇題
            _vocabularyMode.SpeechSelectionQuestion();
            _isAnswerTextBoxEnabled = false;
        }

        private void ProcessFillQuestion()//填充題處理工作
        {
            _questionGroupBoxText = QUESTION_ABBREVIATION + (_vocabularyMode.NumberOfAnswered + 1).ToString() + FILL_QUESTION_TIP; //填充題題目說明
            _questionLabelText = _vocabularyMode.GetNewFillQuestion(); //產生新填充題
            _isFillQuestionTableLayoutPanelVisiabled = true; //顯示填充題
            _isSelectionQuestionTableLayoutPanelVisabled = false; //不顯示選擇題
            _isAnswerTextBoxEnabled = true;
        }

        public void PressListenButton() //按下Listen按鈕
        {
            _vocabularyMode.SpeechSelectionQuestion(); //讀出題目
        }

        public void PressStartButton(int numberOfQuestions, int questionType)  //按下Start按鈕
        {
            _vocabularyMode.NumberOfQuestion = numberOfQuestions;
            _vocabularyMode.QuestionType = questionType;
            _isStartButtonEnabled = false;
            _startToolStripMenuItemEnabled = false;
            _isNextButtonEnabled = true;
            _nextToolStripMenuItemEnabled = true;
            _isAnswerTextBoxEnabled = true;
            _isStopButtonEnabled = true;
            _stopToolStripMenuItemEnabled = true;
            _isChooseNumberOfQuestionLayoutPanelVisiabled = false;
            _statusBarText = EMPTY;
            _isStartTest = true;
            _vocabularyMode.CreateQuestionType();  // 隨機選擇題型
            CreateQuestion();
        }

        private void CreateQuestion()
        {
            if (_vocabularyMode.IsFillQuestion) //依照題型產生題目
                ProcessFillQuestion();
            else
                ProcessSelectionQuestion();
        }

        public void PressNextButton(string answer, int selectedIndex)//按下NEXT按鈕
        {
            _previousFillQuestionAnswer = _vocabularyMode.FillAnswer;
            _previousSelectionAnswer = _vocabularyMode.SelectionAnswer;
            _statusBarText = _vocabularyMode.CheckAnswer(answer,selectedIndex); //檢查答案
            if (_vocabularyMode.IsEndOfQuestion) //若以達到結束 顯示分數 並且重新初始化
                ProcessEndQuestion();
            else //若並未結束 則隨機產生考試型別 依照型別產生問題
            {
                _vocabularyMode.CreateQuestionType();
                CreateQuestion();
            }
        }

        private void ProcessEndQuestion()   //結束測驗問題所做的處理
        {
            _messageBoxText = SCORE_CHINESE + _vocabularyMode.Score.ToString(DOUBLE_SHOW_FORMAT) + PERCENTAGE_SYMBOLE + BLANK + LEFT_BRACKETS + _vocabularyMode.NumberOfCorrect.ToString() + LEFT_DIAGONAL + _vocabularyMode.NumberOfQuestion.ToString() + RIGHT_BRACKETS;
            _vocabularyMode.Initialize();
            Initialize();
            _isChooseNumberOfQuestionLayoutPanelVisiabled = true;
            _isStartTest = false;
        }

        public void PressStopButton(string answer, int selectedIndex)  //按下Stop按鈕
        {
            _vocabularyMode.NumberOfQuestion = _vocabularyMode.NumberOfAnswered + 1;
            PressNextButton(answer, selectedIndex);
        }

        public string AboutDictionaryMessageBoxText
        {
            get
            {
                return ABOUT_DICTIONARY_MESSAGEBOX_TEXT_INFRONT_OF_INTS + BLANK + _vocabularyMode.NumberOfVocabulary + BLANK + ABOUT_DICTIONARY_MESSAGEBOX_TEXT_BEHIND_OF_INTS;
            }
        }

        public System.Drawing.Size FormSize //取得表單的大小
        {
            get
            {
                const int SIZE_OF_FILL_QUESTION_DIALOG_HIGHT = 208;
                const int SIZE_OF_SELECTION_QUESTION_DIALOG_HIGHT = 344;
                const int SIZE_OF_CHOOSE_NUMBER_OF_QUESTION_DIALOG_HIGHT = 208;
                const int SIZE_OF_SELECTION_QUESTION_DIALOG_WIDETH = 350;
                const int SIZE_OF_FILL_QUESTION_DIALOG_WIDTH = 370;
                const int SIZE_OF_CHOOSE_NUMBER_OF_QUESTION_DIALOG_WIDTH = 500;
                if (_isStartTest)
                {
                    if (_vocabularyMode.IsFillQuestion)
                        return new System.Drawing.Size(SIZE_OF_FILL_QUESTION_DIALOG_WIDTH, SIZE_OF_FILL_QUESTION_DIALOG_HIGHT);
                    else
                        return new System.Drawing.Size(SIZE_OF_SELECTION_QUESTION_DIALOG_WIDETH, SIZE_OF_SELECTION_QUESTION_DIALOG_HIGHT);
                }
                else
                    return new System.Drawing.Size(SIZE_OF_CHOOSE_NUMBER_OF_QUESTION_DIALOG_WIDTH, SIZE_OF_CHOOSE_NUMBER_OF_QUESTION_DIALOG_HIGHT);
            }
        }

        public string PreviousFillQuestionAnswer //取得前一提填充題答案
        {
            get
            {
                return _previousFillQuestionAnswer;
            }
        }

        public int PreviousSelectionAnswer //取得前一題選擇題答案
        {
            get
            {
                return _previousSelectionAnswer;
            }
        }
    }
}

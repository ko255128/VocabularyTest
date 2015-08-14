namespace VocabularyTest
{
    partial class VocabularyTestView
    {
        /// <summary>
        /// 設計工具所需的變數。
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// 清除任何使用中的資源。
        /// </summary>
        /// <param name="disposing">如果應該處置 Managed 資源則為 true，否則為 false。</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form 設計工具產生的程式碼

        /// <summary>
        /// 此為設計工具支援所需的方法 - 請勿使用程式碼編輯器
        /// 修改這個方法的內容。
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(VocabularyTestView));
            this._nextButton = new System.Windows.Forms.Button();
            this._startButton = new System.Windows.Forms.Button();
            this._vocabularyTestStatusStrip = new System.Windows.Forms.StatusStrip();
            this._reminTimeToolStripStatusLabel = new System.Windows.Forms.ToolStripStatusLabel();
            this._toolStripStatusLabel = new System.Windows.Forms.ToolStripStatusLabel();
            this._menuStrip = new System.Windows.Forms.MenuStrip();
            this._fileToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this._exitToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this._examinationToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this._startToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this._nextToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this._stopToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this._toolStripSeparator = new System.Windows.Forms.ToolStripSeparator();
            this._numberOfQuestionToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this._tenQuestionsToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this._twentyQuestionsToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this._fiftyQuestionsToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this._questionTypeToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this._allFillInTheBlankQuestionsToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this._allListeningComprehensionMultipleChoiceQuestionsToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this._pickUpQuestionsRndomlyToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this._helpToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this._aboutDirectionaryToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this._aboutSpellingCheckerToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this._questionGroupBox = new System.Windows.Forms.GroupBox();
            this._chooseNumberOfQuesiontTableLayoutPanel = new System.Windows.Forms.TableLayoutPanel();
            this._numberOfQuestionLabel = new System.Windows.Forms.Label();
            this._numberOfQuestionNumericUpDown = new System.Windows.Forms.NumericUpDown();
            this._questionTypeComboBox = new System.Windows.Forms.ComboBox();
            this._selectionQuestionTableLayoutPanel = new System.Windows.Forms.TableLayoutPanel();
            this._listenButton = new System.Windows.Forms.Button();
            this._firstSelectionRadioButton = new System.Windows.Forms.RadioButton();
            this._secondSelectionRadioButton = new System.Windows.Forms.RadioButton();
            this._thirdSelectionRadioButton = new System.Windows.Forms.RadioButton();
            this._fourthRadioButton = new System.Windows.Forms.RadioButton();
            this._fillQuestionTableLayoutPanel = new System.Windows.Forms.TableLayoutPanel();
            this._chineseLabel = new System.Windows.Forms.Label();
            this._englishLabel = new System.Windows.Forms.Label();
            this._questionLabel = new System.Windows.Forms.Label();
            this._answerTextBox = new System.Windows.Forms.TextBox();
            this._viewTableLayoutPanel = new System.Windows.Forms.TableLayoutPanel();
            this._stopButton = new System.Windows.Forms.Button();
            this._timeLabel = new System.Windows.Forms.Label();
            this._timeProgressBar = new System.Windows.Forms.ProgressBar();
            this._vocabularyTestStatusStrip.SuspendLayout();
            this._menuStrip.SuspendLayout();
            this._questionGroupBox.SuspendLayout();
            this._chooseNumberOfQuesiontTableLayoutPanel.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this._numberOfQuestionNumericUpDown)).BeginInit();
            this._selectionQuestionTableLayoutPanel.SuspendLayout();
            this._fillQuestionTableLayoutPanel.SuspendLayout();
            this._viewTableLayoutPanel.SuspendLayout();
            this.SuspendLayout();
            // 
            // _nextButton
            // 
            this._nextButton.AutoSize = true;
            this._nextButton.Dock = System.Windows.Forms.DockStyle.Fill;
            this._nextButton.Location = new System.Drawing.Point(103, 112);
            this._nextButton.Name = "_nextButton";
            this._nextButton.Size = new System.Drawing.Size(94, 27);
            this._nextButton.TabIndex = 3;
            this._nextButton.Text = "Next";
            this._nextButton.UseVisualStyleBackColor = true;
            this._nextButton.Click += new System.EventHandler(this.PressNextButton);
            // 
            // _startButton
            // 
            this._startButton.AutoSize = true;
            this._startButton.Dock = System.Windows.Forms.DockStyle.Fill;
            this._startButton.Location = new System.Drawing.Point(3, 112);
            this._startButton.Name = "_startButton";
            this._startButton.Size = new System.Drawing.Size(94, 27);
            this._startButton.TabIndex = 2;
            this._startButton.Text = "Start";
            this._startButton.UseVisualStyleBackColor = true;
            this._startButton.Click += new System.EventHandler(this.PressStartButton);
            // 
            // _vocabularyTestStatusStrip
            // 
            this._viewTableLayoutPanel.SetColumnSpan(this._vocabularyTestStatusStrip, 3);
            this._vocabularyTestStatusStrip.Dock = System.Windows.Forms.DockStyle.Fill;
            this._vocabularyTestStatusStrip.GripStyle = System.Windows.Forms.ToolStripGripStyle.Visible;
            this._vocabularyTestStatusStrip.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this._reminTimeToolStripStatusLabel,
            this._toolStripStatusLabel});
            this._vocabularyTestStatusStrip.Location = new System.Drawing.Point(0, 165);
            this._vocabularyTestStatusStrip.Name = "_vocabularyTestStatusStrip";
            this._vocabularyTestStatusStrip.RenderMode = System.Windows.Forms.ToolStripRenderMode.Professional;
            this._vocabularyTestStatusStrip.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this._vocabularyTestStatusStrip.Size = new System.Drawing.Size(302, 20);
            this._vocabularyTestStatusStrip.TabIndex = 1;
            // 
            // _reminTimeToolStripStatusLabel
            // 
            this._reminTimeToolStripStatusLabel.Name = "_reminTimeToolStripStatusLabel";
            this._reminTimeToolStripStatusLabel.Size = new System.Drawing.Size(0, 15);
            this._reminTimeToolStripStatusLabel.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // _toolStripStatusLabel
            // 
            this._toolStripStatusLabel.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None;
            this._toolStripStatusLabel.Name = "_toolStripStatusLabel";
            this._toolStripStatusLabel.Size = new System.Drawing.Size(0, 15);
            // 
            // _menuStrip
            // 
            this._viewTableLayoutPanel.SetColumnSpan(this._menuStrip, 3);
            this._menuStrip.Dock = System.Windows.Forms.DockStyle.Fill;
            this._menuStrip.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this._fileToolStripMenuItem,
            this._examinationToolStripMenuItem,
            this._helpToolStripMenuItem});
            this._menuStrip.Location = new System.Drawing.Point(0, 0);
            this._menuStrip.Name = "_menuStrip";
            this._menuStrip.Size = new System.Drawing.Size(302, 23);
            this._menuStrip.TabIndex = 5;
            this._menuStrip.Text = "menuStrip1";
            // 
            // _fileToolStripMenuItem
            // 
            this._fileToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this._exitToolStripMenuItem});
            this._fileToolStripMenuItem.Name = "_fileToolStripMenuItem";
            this._fileToolStripMenuItem.Size = new System.Drawing.Size(39, 19);
            this._fileToolStripMenuItem.Text = "File";
            // 
            // _exitToolStripMenuItem
            // 
            this._exitToolStripMenuItem.Image = global::VocabularyTest.Properties.Resources.EXIT;
            this._exitToolStripMenuItem.Name = "_exitToolStripMenuItem";
            this._exitToolStripMenuItem.Size = new System.Drawing.Size(96, 22);
            this._exitToolStripMenuItem.Text = "Exit";
            this._exitToolStripMenuItem.Click += new System.EventHandler(this.ClickExitToolStripMenuItem);
            // 
            // _examinationToolStripMenuItem
            // 
            this._examinationToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this._startToolStripMenuItem,
            this._nextToolStripMenuItem,
            this._stopToolStripMenuItem,
            this._toolStripSeparator,
            this._numberOfQuestionToolStripMenuItem,
            this._questionTypeToolStripMenuItem});
            this._examinationToolStripMenuItem.Name = "_examinationToolStripMenuItem";
            this._examinationToolStripMenuItem.Size = new System.Drawing.Size(93, 19);
            this._examinationToolStripMenuItem.Text = "Examination ";
            // 
            // _startToolStripMenuItem
            // 
            this._startToolStripMenuItem.Image = global::VocabularyTest.Properties.Resources.Start;
            this._startToolStripMenuItem.Name = "_startToolStripMenuItem";
            this._startToolStripMenuItem.Size = new System.Drawing.Size(192, 22);
            this._startToolStripMenuItem.Text = "Start";
            this._startToolStripMenuItem.Click += new System.EventHandler(this.PressStartButton);
            // 
            // _nextToolStripMenuItem
            // 
            this._nextToolStripMenuItem.Image = global::VocabularyTest.Properties.Resources.next;
            this._nextToolStripMenuItem.Name = "_nextToolStripMenuItem";
            this._nextToolStripMenuItem.Size = new System.Drawing.Size(192, 22);
            this._nextToolStripMenuItem.Text = "Next";
            this._nextToolStripMenuItem.Click += new System.EventHandler(this.PressNextButton);
            // 
            // _stopToolStripMenuItem
            // 
            this._stopToolStripMenuItem.Image = global::VocabularyTest.Properties.Resources.stop;
            this._stopToolStripMenuItem.Name = "_stopToolStripMenuItem";
            this._stopToolStripMenuItem.Size = new System.Drawing.Size(192, 22);
            this._stopToolStripMenuItem.Text = "Stop";
            this._stopToolStripMenuItem.Click += new System.EventHandler(this.PressStopButton);
            // 
            // _toolStripSeparator
            // 
            this._toolStripSeparator.Name = "_toolStripSeparator";
            this._toolStripSeparator.Size = new System.Drawing.Size(189, 6);
            // 
            // _numberOfQuestionToolStripMenuItem
            // 
            this._numberOfQuestionToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this._tenQuestionsToolStripMenuItem,
            this._twentyQuestionsToolStripMenuItem,
            this._fiftyQuestionsToolStripMenuItem});
            this._numberOfQuestionToolStripMenuItem.Name = "_numberOfQuestionToolStripMenuItem";
            this._numberOfQuestionToolStripMenuItem.Size = new System.Drawing.Size(192, 22);
            this._numberOfQuestionToolStripMenuItem.Text = "Number of Question";
            // 
            // _tenQuestionsToolStripMenuItem
            // 
            this._tenQuestionsToolStripMenuItem.Name = "_tenQuestionsToolStripMenuItem";
            this._tenQuestionsToolStripMenuItem.Size = new System.Drawing.Size(149, 22);
            this._tenQuestionsToolStripMenuItem.Text = "10 Questions";
            this._tenQuestionsToolStripMenuItem.Click += new System.EventHandler(this.ClickTenQuestion);
            // 
            // _twentyQuestionsToolStripMenuItem
            // 
            this._twentyQuestionsToolStripMenuItem.Name = "_twentyQuestionsToolStripMenuItem";
            this._twentyQuestionsToolStripMenuItem.Size = new System.Drawing.Size(149, 22);
            this._twentyQuestionsToolStripMenuItem.Text = "20 Questions";
            this._twentyQuestionsToolStripMenuItem.Click += new System.EventHandler(this.ClickTwentyQuestion);
            // 
            // _fiftyQuestionsToolStripMenuItem
            // 
            this._fiftyQuestionsToolStripMenuItem.Name = "_fiftyQuestionsToolStripMenuItem";
            this._fiftyQuestionsToolStripMenuItem.Size = new System.Drawing.Size(149, 22);
            this._fiftyQuestionsToolStripMenuItem.Text = "50 Questions";
            this._fiftyQuestionsToolStripMenuItem.Click += new System.EventHandler(this.ClickFiftyQuestion);
            // 
            // _questionTypeToolStripMenuItem
            // 
            this._questionTypeToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this._allFillInTheBlankQuestionsToolStripMenuItem,
            this._allListeningComprehensionMultipleChoiceQuestionsToolStripMenuItem,
            this._pickUpQuestionsRndomlyToolStripMenuItem});
            this._questionTypeToolStripMenuItem.Name = "_questionTypeToolStripMenuItem";
            this._questionTypeToolStripMenuItem.Size = new System.Drawing.Size(192, 22);
            this._questionTypeToolStripMenuItem.Text = "Question Type";
            // 
            // _allFillInTheBlankQuestionsToolStripMenuItem
            // 
            this._allFillInTheBlankQuestionsToolStripMenuItem.AccessibleName = "AllFillInTheBlankQuestion";
            this._allFillInTheBlankQuestionsToolStripMenuItem.Name = "_allFillInTheBlankQuestionsToolStripMenuItem";
            this._allFillInTheBlankQuestionsToolStripMenuItem.Size = new System.Drawing.Size(383, 22);
            this._allFillInTheBlankQuestionsToolStripMenuItem.Text = "All fill in the blank questions";
            this._allFillInTheBlankQuestionsToolStripMenuItem.Click += new System.EventHandler(this.ClickAllFillInTheBlankQuestionsToolStripMenuItem);
            // 
            // _allListeningComprehensionMultipleChoiceQuestionsToolStripMenuItem
            // 
            this._allListeningComprehensionMultipleChoiceQuestionsToolStripMenuItem.Name = "_allListeningComprehensionMultipleChoiceQuestionsToolStripMenuItem";
            this._allListeningComprehensionMultipleChoiceQuestionsToolStripMenuItem.Size = new System.Drawing.Size(383, 22);
            this._allListeningComprehensionMultipleChoiceQuestionsToolStripMenuItem.Text = "All listening-comprehension-multiple-choice questions";
            this._allListeningComprehensionMultipleChoiceQuestionsToolStripMenuItem.Click += new System.EventHandler(this.ClickAllListeningComprehensionMultipleChoiceQuestionsToolStripMenuItem);
            // 
            // _pickUpQuestionsRndomlyToolStripMenuItem
            // 
            this._pickUpQuestionsRndomlyToolStripMenuItem.Checked = true;
            this._pickUpQuestionsRndomlyToolStripMenuItem.CheckState = System.Windows.Forms.CheckState.Checked;
            this._pickUpQuestionsRndomlyToolStripMenuItem.Name = "_pickUpQuestionsRndomlyToolStripMenuItem";
            this._pickUpQuestionsRndomlyToolStripMenuItem.Size = new System.Drawing.Size(383, 22);
            this._pickUpQuestionsRndomlyToolStripMenuItem.Text = "Pick up questions rndomly";
            this._pickUpQuestionsRndomlyToolStripMenuItem.Click += new System.EventHandler(this.ClickPickUpQuestionsRndomlyToolStripMenuItem);
            // 
            // _helpToolStripMenuItem
            // 
            this._helpToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this._aboutDirectionaryToolStripMenuItem,
            this._aboutSpellingCheckerToolStripMenuItem});
            this._helpToolStripMenuItem.Name = "_helpToolStripMenuItem";
            this._helpToolStripMenuItem.Size = new System.Drawing.Size(47, 19);
            this._helpToolStripMenuItem.Text = "Help";
            // 
            // _aboutDirectionaryToolStripMenuItem
            // 
            this._aboutDirectionaryToolStripMenuItem.Name = "_aboutDirectionaryToolStripMenuItem";
            this._aboutDirectionaryToolStripMenuItem.Size = new System.Drawing.Size(208, 22);
            this._aboutDirectionaryToolStripMenuItem.Text = "About Dictionary";
            this._aboutDirectionaryToolStripMenuItem.Click += new System.EventHandler(this.ClickAboutDictionaryToolStripMenuItem);
            // 
            // _aboutSpellingCheckerToolStripMenuItem
            // 
            this._aboutSpellingCheckerToolStripMenuItem.Image = global::VocabularyTest.Properties.Resources.About;
            this._aboutSpellingCheckerToolStripMenuItem.Name = "_aboutSpellingCheckerToolStripMenuItem";
            this._aboutSpellingCheckerToolStripMenuItem.Size = new System.Drawing.Size(208, 22);
            this._aboutSpellingCheckerToolStripMenuItem.Text = "About Spelling Checker";
            this._aboutSpellingCheckerToolStripMenuItem.Click += new System.EventHandler(this.ClickAboutSpellingChecker);
            // 
            // _questionGroupBox
            // 
            this._questionGroupBox.AutoSize = true;
            this._viewTableLayoutPanel.SetColumnSpan(this._questionGroupBox, 3);
            this._questionGroupBox.Controls.Add(this._chooseNumberOfQuesiontTableLayoutPanel);
            this._questionGroupBox.Controls.Add(this._selectionQuestionTableLayoutPanel);
            this._questionGroupBox.Controls.Add(this._fillQuestionTableLayoutPanel);
            this._questionGroupBox.Dock = System.Windows.Forms.DockStyle.Fill;
            this._questionGroupBox.Location = new System.Drawing.Point(3, 26);
            this._questionGroupBox.Name = "_questionGroupBox";
            this._questionGroupBox.Size = new System.Drawing.Size(296, 80);
            this._questionGroupBox.TabIndex = 0;
            this._questionGroupBox.TabStop = false;
            // 
            // _chooseNumberOfQuesiontTableLayoutPanel
            // 
            this._chooseNumberOfQuesiontTableLayoutPanel.AutoSize = true;
            this._chooseNumberOfQuesiontTableLayoutPanel.ColumnCount = 2;
            this._chooseNumberOfQuesiontTableLayoutPanel.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 38.62069F));
            this._chooseNumberOfQuesiontTableLayoutPanel.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 61.37931F));
            this._chooseNumberOfQuesiontTableLayoutPanel.Controls.Add(this._numberOfQuestionLabel, 0, 0);
            this._chooseNumberOfQuesiontTableLayoutPanel.Controls.Add(this._numberOfQuestionNumericUpDown, 1, 0);
            this._chooseNumberOfQuesiontTableLayoutPanel.Controls.Add(this._questionTypeComboBox, 1, 1);
            this._chooseNumberOfQuesiontTableLayoutPanel.Dock = System.Windows.Forms.DockStyle.Fill;
            this._chooseNumberOfQuesiontTableLayoutPanel.Location = new System.Drawing.Point(3, 18);
            this._chooseNumberOfQuesiontTableLayoutPanel.Name = "_chooseNumberOfQuesiontTableLayoutPanel";
            this._chooseNumberOfQuesiontTableLayoutPanel.RowCount = 2;
            this._chooseNumberOfQuesiontTableLayoutPanel.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this._chooseNumberOfQuesiontTableLayoutPanel.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 30F));
            this._chooseNumberOfQuesiontTableLayoutPanel.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this._chooseNumberOfQuesiontTableLayoutPanel.Size = new System.Drawing.Size(290, 59);
            this._chooseNumberOfQuesiontTableLayoutPanel.TabIndex = 2;
            // 
            // _numberOfQuestionLabel
            // 
            this._numberOfQuestionLabel.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this._numberOfQuestionLabel.AutoSize = true;
            this._numberOfQuestionLabel.Location = new System.Drawing.Point(3, 23);
            this._numberOfQuestionLabel.Name = "_numberOfQuestionLabel";
            this._chooseNumberOfQuesiontTableLayoutPanel.SetRowSpan(this._numberOfQuestionLabel, 2);
            this._numberOfQuestionLabel.Size = new System.Drawing.Size(105, 12);
            this._numberOfQuestionLabel.TabIndex = 0;
            this._numberOfQuestionLabel.Text = "Number of Questions";
            // 
            // _numberOfQuestionNumericUpDown
            // 
            this._numberOfQuestionNumericUpDown.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this._numberOfQuestionNumericUpDown.AutoSize = true;
            this._numberOfQuestionNumericUpDown.Location = new System.Drawing.Point(114, 3);
            this._numberOfQuestionNumericUpDown.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this._numberOfQuestionNumericUpDown.Name = "_numberOfQuestionNumericUpDown";
            this._numberOfQuestionNumericUpDown.Size = new System.Drawing.Size(173, 22);
            this._numberOfQuestionNumericUpDown.TabIndex = 1;
            this._numberOfQuestionNumericUpDown.Value = new decimal(new int[] {
            10,
            0,
            0,
            0});
            // 
            // _questionTypeComboBox
            // 
            this._questionTypeComboBox.AccessibleName = "QuestionTypecomboBox";
            this._questionTypeComboBox.Dock = System.Windows.Forms.DockStyle.Fill;
            this._questionTypeComboBox.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this._questionTypeComboBox.FormattingEnabled = true;
            this._questionTypeComboBox.Items.AddRange(new object[] {
            "all fill-in-blanks questions",
            "all listening-comprehension-multiple-choices questions",
            "pick up questions randomly"});
            this._questionTypeComboBox.Location = new System.Drawing.Point(114, 32);
            this._questionTypeComboBox.Name = "_questionTypeComboBox";
            this._questionTypeComboBox.Size = new System.Drawing.Size(173, 20);
            this._questionTypeComboBox.TabIndex = 2;
            this._questionTypeComboBox.SelectedIndexChanged += new System.EventHandler(this.QuestionTypeComboBoxSelectedIndexChanged);
            // 
            // _selectionQuestionTableLayoutPanel
            // 
            this._selectionQuestionTableLayoutPanel.AutoSize = true;
            this._selectionQuestionTableLayoutPanel.ColumnCount = 2;
            this._selectionQuestionTableLayoutPanel.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 70F));
            this._selectionQuestionTableLayoutPanel.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this._selectionQuestionTableLayoutPanel.Controls.Add(this._listenButton, 0, 0);
            this._selectionQuestionTableLayoutPanel.Controls.Add(this._firstSelectionRadioButton, 0, 1);
            this._selectionQuestionTableLayoutPanel.Controls.Add(this._secondSelectionRadioButton, 0, 2);
            this._selectionQuestionTableLayoutPanel.Controls.Add(this._thirdSelectionRadioButton, 0, 3);
            this._selectionQuestionTableLayoutPanel.Controls.Add(this._fourthRadioButton, 0, 4);
            this._selectionQuestionTableLayoutPanel.Dock = System.Windows.Forms.DockStyle.Fill;
            this._selectionQuestionTableLayoutPanel.Location = new System.Drawing.Point(3, 18);
            this._selectionQuestionTableLayoutPanel.Name = "_selectionQuestionTableLayoutPanel";
            this._selectionQuestionTableLayoutPanel.RowCount = 5;
            this._selectionQuestionTableLayoutPanel.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 30F));
            this._selectionQuestionTableLayoutPanel.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 30F));
            this._selectionQuestionTableLayoutPanel.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 37F));
            this._selectionQuestionTableLayoutPanel.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 45F));
            this._selectionQuestionTableLayoutPanel.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 49F));
            this._selectionQuestionTableLayoutPanel.Size = new System.Drawing.Size(290, 59);
            this._selectionQuestionTableLayoutPanel.TabIndex = 1;
            this._selectionQuestionTableLayoutPanel.Visible = false;
            // 
            // _listenButton
            // 
            this._listenButton.AutoSize = true;
            this._listenButton.Dock = System.Windows.Forms.DockStyle.Fill;
            this._listenButton.Location = new System.Drawing.Point(3, 3);
            this._listenButton.Name = "_listenButton";
            this._listenButton.Size = new System.Drawing.Size(64, 24);
            this._listenButton.TabIndex = 0;
            this._listenButton.Text = "Listen";
            this._listenButton.UseVisualStyleBackColor = true;
            this._listenButton.Click += new System.EventHandler(this.PressListenButton);
            // 
            // _firstSelectionRadioButton
            // 
            this._firstSelectionRadioButton.AutoSize = true;
            this._selectionQuestionTableLayoutPanel.SetColumnSpan(this._firstSelectionRadioButton, 2);
            this._firstSelectionRadioButton.Dock = System.Windows.Forms.DockStyle.Fill;
            this._firstSelectionRadioButton.Location = new System.Drawing.Point(3, 33);
            this._firstSelectionRadioButton.Name = "_firstSelectionRadioButton";
            this._firstSelectionRadioButton.Size = new System.Drawing.Size(284, 24);
            this._firstSelectionRadioButton.TabIndex = 1;
            this._firstSelectionRadioButton.TabStop = true;
            this._firstSelectionRadioButton.UseVisualStyleBackColor = true;
            this._firstSelectionRadioButton.Click += new System.EventHandler(this.PressFirstSelectRadioItem);
            // 
            // _secondSelectionRadioButton
            // 
            this._secondSelectionRadioButton.AutoSize = true;
            this._selectionQuestionTableLayoutPanel.SetColumnSpan(this._secondSelectionRadioButton, 2);
            this._secondSelectionRadioButton.Dock = System.Windows.Forms.DockStyle.Fill;
            this._secondSelectionRadioButton.Location = new System.Drawing.Point(3, 63);
            this._secondSelectionRadioButton.Name = "_secondSelectionRadioButton";
            this._secondSelectionRadioButton.Size = new System.Drawing.Size(284, 31);
            this._secondSelectionRadioButton.TabIndex = 2;
            this._secondSelectionRadioButton.TabStop = true;
            this._secondSelectionRadioButton.UseVisualStyleBackColor = true;
            this._secondSelectionRadioButton.Click += new System.EventHandler(this.PressSecondSelectRadioItem);
            // 
            // _thirdSelectionRadioButton
            // 
            this._thirdSelectionRadioButton.AutoSize = true;
            this._selectionQuestionTableLayoutPanel.SetColumnSpan(this._thirdSelectionRadioButton, 2);
            this._thirdSelectionRadioButton.Dock = System.Windows.Forms.DockStyle.Fill;
            this._thirdSelectionRadioButton.Location = new System.Drawing.Point(3, 100);
            this._thirdSelectionRadioButton.Name = "_thirdSelectionRadioButton";
            this._thirdSelectionRadioButton.Size = new System.Drawing.Size(284, 39);
            this._thirdSelectionRadioButton.TabIndex = 3;
            this._thirdSelectionRadioButton.TabStop = true;
            this._thirdSelectionRadioButton.UseVisualStyleBackColor = true;
            this._thirdSelectionRadioButton.Click += new System.EventHandler(this.PressThirdSelectionRadioItem);
            // 
            // _fourthRadioButton
            // 
            this._fourthRadioButton.AutoSize = true;
            this._selectionQuestionTableLayoutPanel.SetColumnSpan(this._fourthRadioButton, 2);
            this._fourthRadioButton.Dock = System.Windows.Forms.DockStyle.Fill;
            this._fourthRadioButton.Location = new System.Drawing.Point(3, 145);
            this._fourthRadioButton.Name = "_fourthRadioButton";
            this._fourthRadioButton.Size = new System.Drawing.Size(284, 43);
            this._fourthRadioButton.TabIndex = 4;
            this._fourthRadioButton.TabStop = true;
            this._fourthRadioButton.UseVisualStyleBackColor = true;
            this._fourthRadioButton.Click += new System.EventHandler(this.PressFourSelectionRadioItem);
            // 
            // _fillQuestionTableLayoutPanel
            // 
            this._fillQuestionTableLayoutPanel.AutoSize = true;
            this._fillQuestionTableLayoutPanel.ColumnCount = 2;
            this._fillQuestionTableLayoutPanel.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 17.15481F));
            this._fillQuestionTableLayoutPanel.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 82.84519F));
            this._fillQuestionTableLayoutPanel.Controls.Add(this._chineseLabel, 0, 0);
            this._fillQuestionTableLayoutPanel.Controls.Add(this._englishLabel, 0, 1);
            this._fillQuestionTableLayoutPanel.Controls.Add(this._questionLabel, 1, 0);
            this._fillQuestionTableLayoutPanel.Controls.Add(this._answerTextBox, 1, 1);
            this._fillQuestionTableLayoutPanel.Dock = System.Windows.Forms.DockStyle.Fill;
            this._fillQuestionTableLayoutPanel.Location = new System.Drawing.Point(3, 18);
            this._fillQuestionTableLayoutPanel.Name = "_fillQuestionTableLayoutPanel";
            this._fillQuestionTableLayoutPanel.RowCount = 2;
            this._fillQuestionTableLayoutPanel.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 49.14286F));
            this._fillQuestionTableLayoutPanel.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50.85714F));
            this._fillQuestionTableLayoutPanel.Size = new System.Drawing.Size(290, 59);
            this._fillQuestionTableLayoutPanel.TabIndex = 0;
            // 
            // _chineseLabel
            // 
            this._chineseLabel.AutoSize = true;
            this._chineseLabel.Dock = System.Windows.Forms.DockStyle.Fill;
            this._chineseLabel.Location = new System.Drawing.Point(3, 0);
            this._chineseLabel.Name = "_chineseLabel";
            this._chineseLabel.Size = new System.Drawing.Size(43, 28);
            this._chineseLabel.TabIndex = 0;
            this._chineseLabel.Text = "Chinese:";
            this._chineseLabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // _englishLabel
            // 
            this._englishLabel.AutoSize = true;
            this._englishLabel.Dock = System.Windows.Forms.DockStyle.Fill;
            this._englishLabel.Location = new System.Drawing.Point(3, 28);
            this._englishLabel.Name = "_englishLabel";
            this._englishLabel.Size = new System.Drawing.Size(43, 31);
            this._englishLabel.TabIndex = 1;
            this._englishLabel.Text = "English:";
            this._englishLabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // _questionLabel
            // 
            this._questionLabel.AutoEllipsis = true;
            this._questionLabel.AutoSize = true;
            this._questionLabel.Dock = System.Windows.Forms.DockStyle.Fill;
            this._questionLabel.Location = new System.Drawing.Point(52, 0);
            this._questionLabel.Name = "_questionLabel";
            this._questionLabel.Size = new System.Drawing.Size(235, 28);
            this._questionLabel.TabIndex = 2;
            this._questionLabel.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // _answerTextBox
            // 
            this._answerTextBox.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this._answerTextBox.Enabled = false;
            this._answerTextBox.Location = new System.Drawing.Point(52, 32);
            this._answerTextBox.Name = "_answerTextBox";
            this._answerTextBox.Size = new System.Drawing.Size(235, 22);
            this._answerTextBox.TabIndex = 3;
            // 
            // _viewTableLayoutPanel
            // 
            this._viewTableLayoutPanel.AutoSize = true;
            this._viewTableLayoutPanel.ColumnCount = 3;
            this._viewTableLayoutPanel.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 100F));
            this._viewTableLayoutPanel.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 100F));
            this._viewTableLayoutPanel.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 102F));
            this._viewTableLayoutPanel.Controls.Add(this._questionGroupBox, 0, 1);
            this._viewTableLayoutPanel.Controls.Add(this._menuStrip, 0, 0);
            this._viewTableLayoutPanel.Controls.Add(this._vocabularyTestStatusStrip, 0, 4);
            this._viewTableLayoutPanel.Controls.Add(this._startButton, 0, 2);
            this._viewTableLayoutPanel.Controls.Add(this._nextButton, 1, 2);
            this._viewTableLayoutPanel.Controls.Add(this._stopButton, 2, 2);
            this._viewTableLayoutPanel.Controls.Add(this._timeLabel, 0, 3);
            this._viewTableLayoutPanel.Controls.Add(this._timeProgressBar, 1, 3);
            this._viewTableLayoutPanel.Dock = System.Windows.Forms.DockStyle.Fill;
            this._viewTableLayoutPanel.Location = new System.Drawing.Point(0, 0);
            this._viewTableLayoutPanel.Name = "_viewTableLayoutPanel";
            this._viewTableLayoutPanel.RowCount = 5;
            this._viewTableLayoutPanel.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 23F));
            this._viewTableLayoutPanel.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this._viewTableLayoutPanel.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 33F));
            this._viewTableLayoutPanel.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 23F));
            this._viewTableLayoutPanel.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this._viewTableLayoutPanel.Size = new System.Drawing.Size(302, 185);
            this._viewTableLayoutPanel.TabIndex = 0;
            // 
            // _stopButton
            // 
            this._stopButton.AutoSize = true;
            this._stopButton.Dock = System.Windows.Forms.DockStyle.Fill;
            this._stopButton.Location = new System.Drawing.Point(203, 112);
            this._stopButton.Name = "_stopButton";
            this._stopButton.Size = new System.Drawing.Size(96, 27);
            this._stopButton.TabIndex = 4;
            this._stopButton.Text = "Stop";
            this._stopButton.UseVisualStyleBackColor = true;
            this._stopButton.Click += new System.EventHandler(this.PressStopButton);
            // 
            // _timeLabel
            // 
            this._timeLabel.AutoSize = true;
            this._timeLabel.Dock = System.Windows.Forms.DockStyle.Fill;
            this._timeLabel.Font = new System.Drawing.Font("新細明體", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this._timeLabel.Location = new System.Drawing.Point(3, 142);
            this._timeLabel.Name = "_timeLabel";
            this._timeLabel.Size = new System.Drawing.Size(94, 23);
            this._timeLabel.TabIndex = 6;
            this._timeLabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // _timeProgressBar
            // 
            this._viewTableLayoutPanel.SetColumnSpan(this._timeProgressBar, 2);
            this._timeProgressBar.Dock = System.Windows.Forms.DockStyle.Fill;
            this._timeProgressBar.Location = new System.Drawing.Point(103, 145);
            this._timeProgressBar.Name = "_timeProgressBar";
            this._timeProgressBar.Size = new System.Drawing.Size(196, 17);
            this._timeProgressBar.TabIndex = 7;
            // 
            // VocabularyTestView
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSize = true;
            this.ClientSize = new System.Drawing.Size(302, 185);
            this.Controls.Add(this._viewTableLayoutPanel);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MainMenuStrip = this._menuStrip;
            this.Name = "VocabularyTestView";
            this.Text = "基本單字2000測驗";
            this._vocabularyTestStatusStrip.ResumeLayout(false);
            this._vocabularyTestStatusStrip.PerformLayout();
            this._menuStrip.ResumeLayout(false);
            this._menuStrip.PerformLayout();
            this._questionGroupBox.ResumeLayout(false);
            this._questionGroupBox.PerformLayout();
            this._chooseNumberOfQuesiontTableLayoutPanel.ResumeLayout(false);
            this._chooseNumberOfQuesiontTableLayoutPanel.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this._numberOfQuestionNumericUpDown)).EndInit();
            this._selectionQuestionTableLayoutPanel.ResumeLayout(false);
            this._selectionQuestionTableLayoutPanel.PerformLayout();
            this._fillQuestionTableLayoutPanel.ResumeLayout(false);
            this._fillQuestionTableLayoutPanel.PerformLayout();
            this._viewTableLayoutPanel.ResumeLayout(false);
            this._viewTableLayoutPanel.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button _nextButton;
        private System.Windows.Forms.Button _startButton;
        private System.Windows.Forms.StatusStrip _vocabularyTestStatusStrip;
        private System.Windows.Forms.TableLayoutPanel _viewTableLayoutPanel;
        private System.Windows.Forms.GroupBox _questionGroupBox;
        private System.Windows.Forms.TableLayoutPanel _chooseNumberOfQuesiontTableLayoutPanel;
        private System.Windows.Forms.Label _numberOfQuestionLabel;
        private System.Windows.Forms.NumericUpDown _numberOfQuestionNumericUpDown;
        private System.Windows.Forms.TableLayoutPanel _selectionQuestionTableLayoutPanel;
        private System.Windows.Forms.Button _listenButton;
        private System.Windows.Forms.RadioButton _firstSelectionRadioButton;
        private System.Windows.Forms.RadioButton _secondSelectionRadioButton;
        private System.Windows.Forms.RadioButton _thirdSelectionRadioButton;
        private System.Windows.Forms.RadioButton _fourthRadioButton;
        private System.Windows.Forms.TableLayoutPanel _fillQuestionTableLayoutPanel;
        private System.Windows.Forms.Label _chineseLabel;
        private System.Windows.Forms.Label _englishLabel;
        private System.Windows.Forms.Label _questionLabel;
        private System.Windows.Forms.TextBox _answerTextBox;
        private System.Windows.Forms.MenuStrip _menuStrip;
        private System.Windows.Forms.ToolStripMenuItem _fileToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem _exitToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem _examinationToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem _numberOfQuestionToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem _tenQuestionsToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem _twentyQuestionsToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem _fiftyQuestionsToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem _questionTypeToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem _allFillInTheBlankQuestionsToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem _allListeningComprehensionMultipleChoiceQuestionsToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem _pickUpQuestionsRndomlyToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem _helpToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem _aboutDirectionaryToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem _aboutSpellingCheckerToolStripMenuItem;
        private System.Windows.Forms.Button _stopButton;
        private System.Windows.Forms.ToolStripStatusLabel _toolStripStatusLabel;
        private System.Windows.Forms.Label _timeLabel;
        private System.Windows.Forms.ProgressBar _timeProgressBar;
        private System.Windows.Forms.ToolStripMenuItem _startToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem _nextToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem _stopToolStripMenuItem;
        private System.Windows.Forms.ToolStripSeparator _toolStripSeparator;
        private System.Windows.Forms.ToolStripStatusLabel _reminTimeToolStripStatusLabel;
        public System.Windows.Forms.ComboBox _questionTypeComboBox;



    }
}


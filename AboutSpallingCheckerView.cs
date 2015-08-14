using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace VocabularyTest
{
    class AboutSpallingCheckerView : Form
    {
        Label _porductName = new Label();                    //產品名稱
        LinkLabel _labName = new LinkLabel();                //實驗室名稱
        LinkLabel _departmentName = new LinkLabel();         //科系名稱
        LinkLabel _schoolName = new LinkLabel();             //學校名稱
        Label _atSymbol = new Label();                       //@符號
        Label _copyright = new Label();                      //COPY RIGHT
        Label _authorName = new Label();                     //作者名稱
        Button _okButton = new Button();                     //OK按鈕
        PictureBox _aboutPictureBox = new PictureBox();      //圖像視窗
        const int NUMBER_OF_ROW = 5;
        const int NUMBER_OF_COLUMN = 2;
        const int ABOUT_PICTURE_NUMBER_OF_SPAN_ROW = 4;
        const int FORM_WIDTH = 280;
        const int FORM_HEIGHT = 150;
        const int ICON_SIZE = 64;
        const string IMAGE_PATH = "Resources/VocabularyTest.png";
        const string PRODUCT_NAME = "基本單字2000測驗";
        const string LAB_NAME = "STD Lab";
        const string DEPARTMENT_NAME = "CSIE,";
        const string SCHOOL_NAME = "NTUT";
        const string AT_SYMBOLE = "@";
        const string COPYRIGHT = "Copyright @ 2011 All right reserved.";
        const string AUTHORNAME = "Steve Chang 張竣翔";
        const string FORM_TEXT = "About Spalling Checker";
        const string OK_BUTTON_TEXT = "OK";
        const string SCHOOL_HYBERLINK = "http://www.ntut.edu.tw";
        
        public AboutSpallingCheckerView()               //宣告建構元
        {
            Text = FORM_TEXT;
            FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            _aboutPictureBox.ImageLocation = IMAGE_PATH;
            _aboutPictureBox.Size = new System.Drawing.Size(ICON_SIZE, ICON_SIZE);
            _aboutPictureBox.SizeMode = PictureBoxSizeMode.Zoom;
            _okButton.Text = OK_BUTTON_TEXT;
            SetLables();
            this.Width = FORM_WIDTH;
            this.Height = FORM_HEIGHT;
            _okButton.Click += new EventHandler(ClickOkButton);
            _departmentName.LinkClicked += new LinkLabelLinkClickedEventHandler(ClickDepartmentNameLink);
            _labName.LinkClicked += new LinkLabelLinkClickedEventHandler(ClickLabNameLink);
            _schoolName.LinkClicked += new LinkLabelLinkClickedEventHandler(ClickSchoolNameLink);
            Enabled = true;
            ControlBox = false;
            CancelButton = _okButton;
            AcceptButton = _okButton;
            AddItem();
            this.Hide();
        }

        void AddItem()           //將物件加入表單中
        {
            this.Controls.Add(_aboutPictureBox);
            this.Controls.Add(_porductName);
            this.Controls.Add(_labName);
            this.Controls.Add(_atSymbol);
            this.Controls.Add(_departmentName);
            this.Controls.Add(_schoolName);
            this.Controls.Add(_copyright);
            this.Controls.Add(_authorName);
            this.Controls.Add(_authorName);
            this.Controls.Add(_okButton);
            InitailizeItemSize();
            InitializeItemLocation();
        }
        private void InitailizeItemSize()
        {
            const int LABEL_HIGHT = 12;
            const int LAB_NAME_LABEL_WIDTH = 50;
            const int AT_SYMBOL_LABEL_WIDTH = 11;
            const int DEPARTMENT_NAME_LABEL_WIDTH = 33;
            const int OK_BUTTON_HIGHT = 25;
            const int OK_BUTTON_WIDTH = 140;
            _labName.Size = new System.Drawing.Size(LAB_NAME_LABEL_WIDTH, LABEL_HIGHT);
            _atSymbol.Size = new System.Drawing.Size(AT_SYMBOL_LABEL_WIDTH, LABEL_HIGHT);
            _departmentName.Size = new System.Drawing.Size(DEPARTMENT_NAME_LABEL_WIDTH, LABEL_HIGHT);
            _okButton.Size = new System.Drawing.Size(OK_BUTTON_WIDTH, OK_BUTTON_HIGHT);
        }

        private void InitializeItemLocation()
        {
            const int ABOUT_PICTUREBOX_LOCATOIN_X = 0;
            const int ABOUT_PICTUREBOX_LOCATOIN_Y = 25;
            const int LOCATION_X_SEVENTY = 70;
            const int PRODUCT_NAME_LOCATION_Y = 10;
            const int LOCATION_Y_THIRTY = 30;
            const int AT_SYMBOL_LOCATION_X = 120;
            const int DEPARTMENT_LOCATION_X = 140;
            const int SCHOOL_NAME_LOCATION_X = 173;
            const int COPYRIGHT_LOCATION_Y = 50;
            const int AUTHOR_NAME_LOCATION_Y = 70;
            const int OK_BUTTON_LOCATION_Y = 95;
            _aboutPictureBox.Location = new System.Drawing.Point(ABOUT_PICTUREBOX_LOCATOIN_X, ABOUT_PICTUREBOX_LOCATOIN_Y);
            _porductName.Location = new System.Drawing.Point(LOCATION_X_SEVENTY, PRODUCT_NAME_LOCATION_Y);
            _labName.Location = new System.Drawing.Point(LOCATION_X_SEVENTY, LOCATION_Y_THIRTY);
            _atSymbol.Location = new System.Drawing.Point(AT_SYMBOL_LOCATION_X, LOCATION_Y_THIRTY);
            _departmentName.Location = new System.Drawing.Point(DEPARTMENT_LOCATION_X, LOCATION_Y_THIRTY);
            _schoolName.Location = new System.Drawing.Point(SCHOOL_NAME_LOCATION_X, LOCATION_Y_THIRTY);
            _copyright.Location = new System.Drawing.Point(LOCATION_X_SEVENTY, COPYRIGHT_LOCATION_Y);
            _authorName.Location = new System.Drawing.Point(LOCATION_X_SEVENTY, AUTHOR_NAME_LOCATION_Y);
            _okButton.Location = new System.Drawing.Point(LOCATION_X_SEVENTY, OK_BUTTON_LOCATION_Y);
        }

        private void ClickOkButton(object sender, EventArgs e)          //點OK的事件
        {
            this.Hide();
        }

        private void ClickLabNameLink(object sender, EventArgs e)      //點LAB的連結事件
        {
            System.Diagnostics.Process.Start(SCHOOL_HYBERLINK);
        }

        private void ClickDepartmentNameLink(object sender, EventArgs e) //點課系的連結事件
        {
            System.Diagnostics.Process.Start(SCHOOL_HYBERLINK);
        }

        private void ClickSchoolNameLink(object sender, EventArgs e)  //點學校的連結事件
        {
            System.Diagnostics.Process.Start(SCHOOL_HYBERLINK);
        }

        private void SetLables()           //設定LABEL
        {
            _porductName.Text = PRODUCT_NAME;
            _copyright.Text = COPYRIGHT;
            _authorName.Text = AUTHORNAME;
            _atSymbol.Text = AT_SYMBOLE;
            _schoolName.Text = SCHOOL_NAME;
            _labName.Text = LAB_NAME;
            _departmentName.Text = DEPARTMENT_NAME;
            _porductName.AutoSize = true;
            _copyright.AutoSize = true;
            _authorName.AutoSize = true;
        }
    }
}

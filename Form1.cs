using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.IO;
using System.Threading;

namespace PassSaver
{
    public partial class Form1 : Form
    {
        bool first = true;        
        String[] Messages = new String[14];
        List<Color> colb = new List<Color>(); //хранит цвет кнопок
        List<Button> btns = new List<Button>(); //быстрое взаимодействие с кнопками
        String editText, addText, rdy; //Изменение текста кнопок
        int indexS,indexL;  //Сохраняем выбранный сайт, логин  (индексы!)
        int countArrSiteName; // Нужно! Для вычисления длины поля сайтов
        String[,,] arr = new String[100,30,4]; //"база данных" [x,y,z] x - названия сайтов, y - логины, z - пароли/почты
        String language;//язык
        public Form1()
        {
            InitializeComponent();
            TopMost = true;
            loadArray("saver.dat"); // загрузка данных из файла в массив
            formUpdate();
            cbSiteLogin.FormattingEnabled = false; // только чтение
           // loadSites();  //Загружаем данные из массива или стандартные сайты
            cbSiteName.DropDownStyle = ComboBoxStyle.DropDownList; //запрещаем писать в комбобоксах
            cbSiteLogin.DropDownStyle = ComboBoxStyle.DropDownList;
            if (language != null)    //подтягиваем язык из настроек
            {
                if (language.Equals("Eng"))
                    lenEn(); 
                else lenRu();
            }
            else lenEn();
            cbSiteName.SelectedIndex = 0; //выбираем 1-й сайт
            foreach (object o in Controls){  //загугленная хрень, забивающая кнопки на форме в массив            
                if ((o as Button) is Button){
                    btns.Add((o as Button));
                    colb.Add((o as Button).ForeColor); // ну надо же от себя добавить что-то :)
                }
            }
            notifyIcon.ContextMenuStrip = contextMenuStrip1;
            rbTopMost.Checked = true;
            
        }
        
       
        private void btnLngEn_Click(object sender, EventArgs e){lenEn();}
        private void btnLngRu_Click(object sender, EventArgs e){lenRu();}
        private void lenEn()
        {
            addText = "Add";
            editText = "Edit";
            rdy = "Accept!";
            btnAddSite.Text = addText;
            btnAddLogin.Text = addText;
            btnCopyLogin.Text = "Copy";
            btnCopyMail.Text = "Copy";
            btnCopyPass.Text = "Copy";
            btnEditLogin.Text = editText;
            btnEditMail.Text = editText;
            btnEditPass.Text = editText;
            btnEditSite.Text = editText;
            btnRemoveLogin.Text = "Remove";
            btnRemoveSite.Text = "Remove";
            lblChooseLogin.Text = "Choose your login:";
            lblLogin.Text = "Login:";
            lblMail.Text = "Mail:";
            lblPassword.Text = "Password:";
            lblSiteName.Text = "Site:";
            tsmiSave.Text = "Save a backup copy";
            tsmiLoad.Text = "Load a backup copy";
            Messages[0] = "Are you sure that you want to delete this site?";
            Messages[1] = "ATTENTION!";
            Messages[2] = "Default websites don't need to delete :)";
            Messages[3] = "Are you sure that you want to delete this login from site ";
            Messages[4] = "Something is wrong with saved file, load the backup! Current file saved in the folder Wtf.";
            Messages[5] = "Danger!";
            Messages[6] = "File ";
            Messages[7] = " successfully loaded.";
            Messages[8] = " successfully saved.";
            Messages[9] = "The file is in use by another program! It will be stored in a folder \"Error\"!";
            Messages[10] = "AUUUUUUU!";
            Messages[11] = "Files are missing!";
            Messages[12] = "You can not add empty lines !!!";
            Messages[13] = "The saved file has too few sites! Most likely, it is corrupted!";
            tsmiClose.Text = "Close";
            rbTopMost.Text = "Always on Top";
            language = "Eng";
            rbTopMost.Checked = false;
        }
        private void lenRu()
        {
            addText = "Добавить";
            editText = "Изменить";
            rdy = "Готово!";
            btnAddSite.Text = addText;
            btnAddLogin.Text = addText;
            btnCopyLogin.Text = "Копировать";
            btnCopyMail.Text = "Копировать";
            btnCopyPass.Text = "Копировать";
            btnEditLogin.Text = editText;
            btnEditMail.Text = editText;
            btnEditPass.Text = editText;
            btnEditSite.Text = editText;
            btnRemoveSite.Text = "Удалить";
            btnRemoveLogin.Text = "Удалить";
            lblChooseLogin.Text = "Выберите логин:";
            lblLogin.Text = "Логин:";
            lblMail.Text = "Почта:";
            lblPassword.Text = "Пароль:";
            lblSiteName.Text = "Сайт:";
            tsmiLoad.Text = "Загрузить резервную копию";
            tsmiSave.Text = "Сохранить резервную копию";
            Messages[0] = "Вы уверены, что хоите удалить этот сайт?";
            Messages[1] = "ВНИМАНИЕ!";
            Messages[2] = "Сайты по умолчанию удалять не надо :)";
            Messages[3] = "Вы уверены, что хотите удалить этот логин из сайта ";
            Messages[4] = "Что-то не так с сохраннёным файлом, загрузите резервную копию! Текущий файл сохранён в папке Wtf";
            Messages[5] = "Дангер!";
            Messages[6] = "Файл ";
            Messages[7] = " успешно загружен.";
            Messages[8] = " успешно сохранён.";
            Messages[9] = "Файл занят другой программой! Он будет сохранён в папке Error!";
            Messages[10] = "АУУУУУУ";
            Messages[11] = "Файлы отсутствуют!";
            Messages[12] = "Нельзя добавлять пустые строки!!!";
            Messages[13] = "В сохранённом файле слишком мало сайтов! Вероятнее всего он испорчен!";
            tsmiClose.Text = "Закрыть";
            rbTopMost.Text = "Поверх всех окон";
            language = "Rus";
            rbTopMost.Checked = true;
        }

        
        
        private void btnVK_Click(object sender, EventArgs e){cbSiteName.SelectedIndex = 0;}
        private void btnOK_Click(object sender, EventArgs e){cbSiteName.SelectedIndex = 1;}
        private void btnSkype_Click(object sender, EventArgs e){cbSiteName.SelectedIndex = 2;}
        private void btnYA_Click(object sender, EventArgs e){cbSiteName.SelectedIndex = 3;}
        private void btnMru_Click(object sender, EventArgs e){cbSiteName.SelectedIndex = 4;}
        private void btnGoogle_Click(object sender, EventArgs e){cbSiteName.SelectedIndex = 5;}

        private void btnRemoveSite_Click(object sender, EventArgs e)
        {
            indexS = cbSiteName.SelectedIndex;//сохраняем выбранный сайт
            DialogResult result = MessageBox.Show(Messages[0], Messages[1], MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (result == DialogResult.Yes) //согласились удалять
            {
                if (indexS < 6) // проверка удаления стандартных сайтов
                {
                    MessageBox.Show(Messages[2]);
                    return;
                }
                cbSiteName.Items.RemoveAt(indexS);//удаление сайта из комбобокса
                for (int i = indexS; i <= cbSiteName.Items.Count; i++) //начало движения - удалённый сайт, конец - последний элемент комбобокса
                {
                    for (int j = 0; j < arr.GetLength(1)-1; j++) //проверка каждого логина для текущего сайта
                    {
                        arr[i, j, 0] = arr[i + 1, j, 0]; // запись сайта на ячейку назад
                        arr[i, j, 1] = arr[i + 1, j, 1]; // запись логина в предыдущий сайт
                        arr[i, j, 2] = arr[i + 1, j, 2]; // запись пароля в предыдущий сайт
                        arr[i, j, 3] = arr[i + 1, j, 3]; // запись почты в предыдущий сайт
                    }
                }
            }
            cbSiteName.SelectedIndex = cbSiteName.Items.Count - 1; // выбор последнего добавленного сайта
            indexS = 0; // обнуляем индекс. Зачем? - не знаю, просто привычка.
            //MessageBox.Show(arr[cbSiteName.Items.Count,0,0].ToString()); // проверял очистку массива
        }
        private void btnRemoveLogin_Click(object sender, EventArgs e)
        {
            if (cbSiteLogin.Items.Count < 1) // Если логина нет, то и удалять нечего
                return;
            indexL = cbSiteLogin.SelectedIndex; // Сохраняем индекс текущего логина
            DialogResult result = MessageBox.Show(Messages[3]+ cbSiteName.Text + "?", Messages[1], MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (result == DialogResult.Yes) // согласились... ок.
            {
                cbSiteLogin.Items.RemoveAt(indexL); //удалить из комбобокса
                for (int i = indexL; i <= cbSiteLogin.Items.Count; i++) // старт - текущий логин, конец - общее число логинов.
                {
                    arr[cbSiteName.SelectedIndex, i, 1] = arr[cbSiteName.SelectedIndex,i + 1, 1]; // Сайт текущий. Логин соседний.
                    arr[cbSiteName.SelectedIndex, i, 2] = arr[cbSiteName.SelectedIndex, i + 1, 2];
                    arr[cbSiteName.SelectedIndex, i, 3] = arr[cbSiteName.SelectedIndex, i + 1, 3];
                }
            }
            cbSiteLogin.SelectedIndex = cbSiteLogin.Items.Count - 1;
            if (cbSiteLogin.SelectedIndex < 0)
            {
                tbLogin.Text = "";
                tbMail.Text = "";
                tbPassword.Text = "";
            }
            indexL = 0;//Вот опять.
        }
        private void btnAddSite_Click(object sender, EventArgs e)
        {
            if (btnAddSite.Text == addText)
            {
                btnInActiveExcept(btnAddSite); //выключаем остальные кнопки 
                cbSiteName.DropDownStyle = ComboBoxStyle.DropDown; // включаем редактирование поля
                btnAddSite.Text = rdy; // меняем название кнопки 
                btnAddSite.ForeColor = Color.Red; //цвет кнопки
                cbSiteName.BackColor = Color.Red; // цвет поля
            }
            else
            {
                btnActive();  //включаем кнопки
                btnAddSite.Text = addText; //возвращаем название
                if (cbSiteName.Text != "")
                    addSite(cbSiteName.Text);
                else
                    MessageBox.Show(Messages[12]);
                cbSiteName.DropDownStyle = ComboBoxStyle.DropDownList; //выключаем редактирование
                cbSiteName.SelectedIndex = cbSiteName.Items.Count-1; //выбор последнего добавленного сайта
                cbSiteName.BackColor = Color.Olive; // цвет поля
            }
        }
        private void btnAddLogin_Click(object sender, EventArgs e)
        {
            if (btnAddLogin.Text == addText)
            {
                btnInActiveExcept(btnAddLogin);
                cbSiteLogin.DropDownStyle = ComboBoxStyle.DropDown;
                btnAddLogin.Text = rdy;
                btnAddLogin.ForeColor = Color.Red;
                cbSiteLogin.BackColor = Color.Red;
            }
            else
            {
                if (cbSiteLogin.Text != "")
                    addLogin(cbSiteLogin.Text);
                else
                    MessageBox.Show(Messages[12]);
                btnActive();
                btnAddLogin.Text = addText;
                cbSiteLogin.DropDownStyle = ComboBoxStyle.DropDownList;
                cbSiteLogin.SelectedIndex = cbSiteLogin.Items.Count - 1;
                cbSiteLogin.BackColor = Color.Tan;
            }
        }

        private void btnCopyLogin_Click(object sender, EventArgs e){if (tbLogin.Text != "")Clipboard.SetText(tbLogin.Text);}
        private void btnCopyPass_Click(object sender, EventArgs e){if (tbPassword.Text != "")Clipboard.SetText(tbPassword.Text);}
        private void btnCopyMail_Click(object sender, EventArgs e){if (tbMail.Text != "")Clipboard.SetText(tbMail.Text);}

        private void btnEditLogin_Click(object sender, EventArgs e)
        {
            if (btnEditLogin.Text == editText)
            {
                btnInActiveExcept(btnEditLogin);
                tbLogin.ReadOnly = false;
                btnEditLogin.ForeColor = Color.Red;
                tbLogin.BackColor = Color.Red;
                btnEditLogin.Text = rdy;
            }
            else
            {
                if (tbLogin.Text == "")
                {
                    btnActive();
                    tbLogin.ReadOnly = true;
                    tbLogin.BackColor = Color.Peru;
                    return;
                }
                if (cbSiteLogin.Items.Count < 1)
                { addLogin(tbLogin.Text); cbSiteLogin.SelectedIndex = 0; }
                arr[cbSiteName.SelectedIndex, cbSiteLogin.SelectedIndex, 1] = tbLogin.Text;
                cbSiteLogin.Items[cbSiteLogin.SelectedIndex] = tbLogin.Text;
                btnActive();
                tbLogin.ReadOnly = true;
                tbLogin.BackColor = Color.Peru;
                btnEditLogin.Text = editText;
            }

        }
        private void btnEditPass_Click(object sender, EventArgs e)
        {
            if (cbSiteLogin.Items.Count < 1)
            {
                MessageBox.Show("Добавте хотя бы 1 логин");
                return;
            }
            if (btnEditPass.Text == editText)
            {
                btnInActiveExcept(btnEditPass);
                tbPassword.ReadOnly = false;
                btnEditPass.ForeColor = Color.Red;
                tbPassword.BackColor = Color.Red;
                btnEditPass.Text = rdy;
            }
            else
            {
                arr[cbSiteName.SelectedIndex, cbSiteLogin.SelectedIndex, 2] = tbPassword.Text;
                btnActive();
                tbPassword.ReadOnly = true;
                tbPassword.BackColor = Color.Peru;
                btnEditPass.Text = editText;
            }
        }
        private void btnEditMail_Click(object sender, EventArgs e)
        {
            if (cbSiteLogin.Items.Count < 1)
            {
                MessageBox.Show("Добавте хотя бы 1 логин");
                return;
            }
            if (btnEditMail.Text == editText)
            {
                btnInActiveExcept(btnEditMail);
                tbMail.ReadOnly = false;
                btnEditMail.ForeColor = Color.Red;
                tbMail.BackColor = Color.Red;
                btnEditMail.Text = rdy;
            }
            else
            {
                arr[cbSiteName.SelectedIndex, cbSiteLogin.SelectedIndex, 3] = tbMail.Text;
                btnActive();
                tbMail.ReadOnly = true;
                tbMail.BackColor = Color.Peru;
                btnEditMail.Text = editText;
            }
        }
        private void btnEditSite_Click(object sender, EventArgs e)
        {
            if (btnEditSite.Text == editText)
            {
                btnInActiveExcept(btnEditSite);
                indexS = cbSiteName.SelectedIndex;
                cbSiteName.DropDownStyle = ComboBoxStyle.DropDown;
                btnEditSite.Text = rdy;
                btnEditSite.ForeColor = Color.Red;
                cbSiteName.BackColor = Color.Red;
            }
            else
            {
                btnActive();
                btnEditSite.Text = editText;
                cbSiteName.Items[indexS] = cbSiteName.Text;
                arr[indexS, 0, 0] = cbSiteName.Text;
                cbSiteName.DropDownStyle = ComboBoxStyle.DropDownList;
                cbSiteName.SelectedIndex = indexS;
                indexS = 0;
                btnEditSite.ForeColor = Color.Yellow;
                cbSiteName.BackColor = Color.Olive;
            }
        }

        private void cbSiteName_DropDown(object sender, EventArgs e) //был пьян. Переписать. Лень =\
        {
            int i;
            if (cbSiteName.SelectedIndex!=-1)
                i = cbSiteName.SelectedIndex;
            else i = 0;
            btnEditSite.Text = editText;
            btnEditLogin.Text = editText;
            btnEditMail.Text = editText;
            btnEditPass.Text = editText;
            btnAddSite.Text = addText;
            btnAddLogin.Text = addText;
            cbSiteName.DropDownStyle = ComboBoxStyle.DropDownList;
            cbSiteLogin.DropDownStyle = ComboBoxStyle.DropDownList;
            cbSiteName.BackColor = Color.Olive;
            cbSiteLogin.BackColor = Color.Tan;
            cbSiteName.SelectedIndex = i;
            btnActive();
            tbLogin.BackColor = Color.Peru;
            tbMail.BackColor = Color.Peru;
            tbPassword.BackColor = Color.Peru;
            tbLogin.ReadOnly = true;
            tbMail.ReadOnly = true;
            tbPassword.ReadOnly = true;
            try
            {
                tbLogin.Text = arr[cbSiteName.SelectedIndex, cbSiteLogin.SelectedIndex, 1];
                tbPassword.Text = arr[cbSiteName.SelectedIndex, cbSiteLogin.SelectedIndex, 2];
                tbMail.Text = arr[cbSiteName.SelectedIndex, cbSiteLogin.SelectedIndex, 3];
            }
            catch
            {
                tbPassword.Text = "";
                tbMail.Text = "";
                tbLogin.Text = "";
            }
        } 
        private void cbSiteLogin_DropDown(object sender, EventArgs e) //см. выше
        {
            int i;
            if (cbSiteName.SelectedIndex != -1)
                i = cbSiteName.SelectedIndex;
            else i = 0;
            btnEditSite.Text = editText;
            btnEditLogin.Text = editText;
            btnEditMail.Text = editText;
            btnEditPass.Text = editText;
            btnAddSite.Text = addText;
            btnAddLogin.Text = addText;
            cbSiteName.DropDownStyle = ComboBoxStyle.DropDownList;
            cbSiteLogin.DropDownStyle = ComboBoxStyle.DropDownList;
            cbSiteName.BackColor = Color.Olive;
            cbSiteLogin.BackColor = Color.Tan;
            cbSiteName.SelectedIndex = i;
            btnActive();
            tbLogin.BackColor = Color.Peru;
            tbMail.BackColor = Color.Peru;
            tbPassword.BackColor = Color.Peru;
            tbLogin.ReadOnly = true;
            tbMail.ReadOnly = true;
            tbPassword.ReadOnly = true;
            try
            {
                tbLogin.Text = arr[cbSiteName.SelectedIndex, cbSiteLogin.SelectedIndex, 1];
                tbPassword.Text = arr[cbSiteName.SelectedIndex, cbSiteLogin.SelectedIndex, 2];
                tbMail.Text = arr[cbSiteName.SelectedIndex, cbSiteLogin.SelectedIndex, 3]; 
            }
            catch
            {
                tbPassword.Text = "";
                tbMail.Text = "";
                tbLogin.Text = "";
            }
        }
        private void cbSiteName_SelectedValueChanged(object sender, EventArgs e)
        { //тут просто задолбался
            loadCbLog();
            if (cbSiteLogin.Items.Count != 0)
                cbSiteLogin.SelectedIndex = 0;
            tbLogin.Text = cbSiteLogin.Text;
            try
            {
                tbPassword.Text = arr[cbSiteName.SelectedIndex, cbSiteLogin.SelectedIndex, 2];
                tbMail.Text = arr[cbSiteName.SelectedIndex, cbSiteLogin.SelectedIndex, 3];
            }
            catch
            {
                tbPassword.Text = "";
                tbMail.Text = "";
            }
        }
        private void cbSiteLogin_SelectedValueChanged(object sender, EventArgs e)
        {
            tbLogin.Text = cbSiteLogin.Text;
            tbPassword.Text = arr[cbSiteName.SelectedIndex, cbSiteLogin.SelectedIndex, 2];
            tbMail.Text = arr[cbSiteName.SelectedIndex, cbSiteLogin.SelectedIndex, 3];
        }

        private void btnInActiveExcept(Button btn) {    //выключение кнопок, кроме переданной. Тут всё просто.
            for (int i = 0; i < btns.Count; i++)
            {
                if (btns[i] != btn)
                {
                    btns[i].Enabled = false;
                    btns[i].ForeColor = Color.Gray;
                }
               // else colb.Add(btns[i].ForeColor); //Остатки от 10-го переписывания метода
            }
            tsmiSave.Enabled = false;
            tsmiLoad.Enabled = false;
        }
        private void btnActive() {
            for (int i = 0; i < btns.Count; i++)  //возвращаем кнопкам цвет и активируем их
            {
                btns[i].Enabled = true;
                btns[i].ForeColor = colb[i];
            }
            tsmiSave.Enabled = true;
            tsmiLoad.Enabled = true;
        }
        private void addSite(String s)
        {
            if (s == "") return;        //не добавлю пустой!
            arr[cbSiteName.Items.Count, 0, 0] = s;  //запись сайта в массив
            cbSiteName.Items.Add(s); // добавление в комбобокс
        }
        private void addLogin(String s)
        {
            if (s == "") return;
            arr[cbSiteName.SelectedIndex, cbSiteLogin.Items.Count, 1] = s; 
            cbSiteLogin.Items.Add(s);
            tbLogin.Text = s;
        }
        private void loadCbLog()
        {
            cbSiteLogin.Items.Clear();  //Чистим комбобокс
            for (int i = 0; i < arr.GetLength(1); i++) //проходимся по логинам этого сайта
            {
                if (cbSiteName.SelectedIndex == -1) // Если сайт не выбран, выбираем 1-й. Зачем это?! ПЕРЕПИСАТЬ!
                    cbSiteName.SelectedIndex = 0;
                if (arr[cbSiteName.SelectedIndex, i, 1] != null)  // А не, всё норм. Если логин есть...
                {
                    if (arr[cbSiteName.SelectedIndex, i, 1]!="")  // и он не пустой
                    cbSiteLogin.Items.Add(arr[cbSiteName.SelectedIndex, i, 1]); //Добавим его в комбобокс.
                }
            }

        }
        private void loadSites()
        {
            if (arr[0,0,0] == null) //Если файла не было => массив не заполнился, 1-го элемента нет, создаю заново.
            {
                addSite("vk.com");
                addSite("ok.ru");
                addSite("Skype");
                addSite("ya.ru");
                addSite("mail.ru");
                addSite("google.com");
            }
            else
            {
                for (int i = 0; i < countArrSiteName; i++)  // при записи строки сайтов счётчик был.. 
                {
                    addSite(arr[i, 0, 0]); //заполнение массива
                }
               // countArrSiteName = 0; // Всё та же привычка.
            }
        }

        private void loadArray(String filename)
        {
            if (first)
                lenEn();
            if (!File.Exists(filename))    //Возможно передать: /saver.dat/, /Backup/saver.dat/. 
                return;
            string line; // Это я загуглил. Так крутые проггеры делают
            List<String> list = new List<string>(); //List - откорректированный список загружаемых настроек.
            StreamReader sr = new StreamReader(File.OpenRead(filename)); //открыл файл настроек
            countArrSiteName = 0; //ВОТ ЭТОТ СЧЁТЧИК! Не зря обнулил.
            try           // и если этот файл никто не ковырял...
            {
                while ((line = sr.ReadLine()) != "%EndFile%") //Читаю каждую строку до %конца файла%
                {
                    if (line.Contains("<S| ")) countArrSiteName++; //Если сайт - увеличить счётчик  //  
                    if ((line != "") && (line != "%Endl%") && (line != null)) // форматирование строк
                    {
                        if ((!line.Contains("<S| ")) && (list.Count % 91 == 0)&&(!line.Contains("%l++"))) // Если на позиции сайта вовсе не сайт...
                        {
                            countArrSiteName++;
                            MessageBox.Show("Error in " + Convert.ToInt32(list.Count / 91) + "site");
                        }
                        if (line.Contains("<S| ") && (list.Count % 91 != 0))   // Если сайт не на своём месте
                        {
                            line = line.Replace("<S| ", "");
                            line = line.Replace(" />", "");
                            MessageBox.Show("Error loading site " + line, Messages[5]); // выводим текущий сайт
                            while (list.Count % 91 != 0)
                            {
                                list.Add("Error. Load the backup!");  // заболняем "ошибочными значениями" все поля.
                            }
                        }
                        line = line.Replace("<S| ", "");
                        line = line.Replace("<L| ", "");
                        line = line.Replace("<P| ", "");
                        line = line.Replace("<M| ", "");
                        line = line.Replace(" />", "");
                        list.Add(line);  //Наконец запилить это всё дело в список
                    }
                }
                CheckFolders();  // Проверка наличия нужных программе папок. Если чё, создадим :)
                sr.Close();  // Вечно забываемая штука. ЗАКРЫТЬ ФАЙЛ!
                if (countArrSiteName < 6)   // Если сайтов меньше 6-ти, выводим ошибку.
                {
                    ErrorLoad(filename);
                    MessageBox.Show(Messages[13], Messages[5]);
                    return;
                }
                for (int i = 0, k = 0; i < countArrSiteName; i++)  // Если файл ковырялся - счётчик не увиличится, цикл пропустится
                {
                    if (list[k] != "")
                        arr[i, 0, 0] = list[k++];  // Разделение списка на 3-хмерный массив
                    else
                        arr[i, 0, 0] = "Было сдвинуто значение!" + k++;
                    for (int j = 0; j < arr.GetLength(1); j++)  // цикл пробежится 30*countArrSiteName раз. Максимум - 6000. Это будет беда
                    {
                        arr[i, j, 1] = list[k++];
                        arr[i, j, 2] = list[k++];
                        arr[i, j, 3] = list[k++];
                    }
                    if (list[k].Contains("%l++"))  // Загрузка языка
                    {
                        language = list[k].Replace("%l++", "");
                        if (!first)
                        {
                            MessageBox.Show(Messages[6] + filename + Messages[7]);
                            first = false;
                        }
                        formUpdate();
                        break;
                    }
                }
            }
            catch // ну, а если ковырял
            {
                sr.Close();  // ЗАКРЫТЬ ФАЙЛ!
                ErrorLoad(filename);
            }
            
            
        }
        private void ErrorLoad(string filename)
        {
            
            CheckFolders(); // Проверка папок
            MessageBox.Show(Messages[4], Messages[5]);
            //var MyFile = File.Create("Wtf/" + filename); // И так сойдёт
            //  MyFile.Close();
            string s = DateTime.Now.ToString();
            s = s.Replace(":", "-");
            s = filename + s;
            s = s.Replace(".dat", "");
            s = s + ".dat";
            File.Copy(filename, ("Wtf/" + s)); //Копирование файла в папку втф
            File.Delete(filename); // удаление файла
        }
        private void saveArray(String fileName)
        {
            fileName = fileName.Replace(":", "-"); // В файле ":" неприемлимо
            CheckFolders(); //проверка и создание папок
            if (!File.Exists(fileName)) // Если файла нет - создаем.
            {
                var myFile = File.Create(fileName);
                myFile.Close();
            }
            FileStream file = new FileStream(fileName, FileMode.Create);//создаем файловый поток
            StreamWriter writer = new StreamWriter(file);//создаем «потоковый писатель» и связываем его с файловым потоком 
            for (int i = 0; i < cbSiteName.Items.Count; i++)
            {
                writer.WriteLine("<S| " + arr[i, 0, 0] + " />"); //записываем в файл

                for (int j = 0; j < arr.GetLength(1); j++)
                {
                    writer.WriteLine("<L| " + arr[i, j, 1] + " />");
                    writer.WriteLine("<P| " + arr[i, j, 2] + " />");
                    writer.WriteLine("<M| " + arr[i, j, 3] + " />");
                    writer.WriteLine();
                }
                writer.WriteLine("%Endl%");
            }
            writer.WriteLine("%l++" + language);
            writer.WriteLine("%EndFile%");
            writer.Close();
            MessageBox.Show(Messages[6] + fileName + Messages[8]);
        }

        private void saveArray(String fileName, String param)
        {
            fileName = fileName.Replace(":", "-"); // В файле ":" неприемлимо
            CheckFolders(); //проверка и создание папок
            if (!File.Exists(fileName)) // Если файла нет - создаем.
            {
                var myFile = File.Create(fileName);
                myFile.Close();
            }
            FileStream file = new FileStream(fileName, FileMode.Create);//создаем файловый поток
            StreamWriter writer = new StreamWriter(file);//создаем «потоковый писатель» и связываем его с файловым потоком 
            for (int i = 0; i < cbSiteName.Items.Count; i++)
            {
                writer.WriteLine("<S| " + arr[i, 0, 0] + " />"); //записываем в файл

                for (int j = 0; j < arr.GetLength(1); j++)
                {
                    writer.WriteLine("<L| " + arr[i, j, 1] + " />");
                    writer.WriteLine("<P| " + arr[i, j, 2] + " />");
                    writer.WriteLine("<M| " + arr[i, j, 3] + " />");
                    writer.WriteLine();
                }
                writer.WriteLine("%Endl%");
            }
            writer.WriteLine("%l++" + language);
            writer.WriteLine("%EndFile%");
            writer.Close();
            if (param == "OnClosing")
                notifyIcon.ShowBalloonTip(1000, Messages[6]+fileName, Messages[8], ToolTipIcon.Info);
            else
            MessageBox.Show(Messages[6] + fileName + Messages[8]);
        }
        
        public bool CheckIfFileIsBeingUsed(string fileName)
        {
            try
            {
                var myFile = File.Open(fileName, FileMode.Open, FileAccess.Read, FileShare.None);
                myFile.Close();
            }

            catch 
            {
                return true;
            }
            return false;
        }

        private void tsmiSave_Click(object sender, EventArgs e){saveArray("Backup/saver " + DateTime.Now.ToString() + ".dat");}

        private void CheckFolders()
        {
            if (!Directory.Exists("Error"))
                Directory.CreateDirectory("Error");
            if (!Directory.Exists("Backup"))
                Directory.CreateDirectory("Backup");
            if (!Directory.Exists("Wtf"))
                Directory.CreateDirectory("Wtf");
        }

        private void tsmiLoad_Click(object sender, EventArgs e)
        {
            loadBackup(); 
        }
        private void open_Click(object sender, EventArgs e)
        {
            string s = sender.ToString();
            s = "Backup/saver "+s+".dat";
            loadArray(s);      
        }
        private void loadBackup()
        {
            tsmiLoad.DropDownItems.Clear();
            String[] files = Directory.GetFiles("Backup", "*.dat");
            if (files.Length < 1) { MessageBox.Show(Messages[11], Messages[1]); return; }
                for (int i = 0; i < files.Length; i++)
                {
                    files[i] = files[i].Replace(".dat", "");
                    files[i] = files[i].Replace("saver ", "");
                    files[i] = files[i].Replace("Backup", "");
                    files[i] = files[i].Remove(0, 1);
                    ToolStripMenuItem windowNewMenu = new ToolStripMenuItem(files[i], null, new EventHandler(open_Click));
                    tsmiLoad.DropDownItems.Add(windowNewMenu);
                }
        }
        public void formUpdate()
        {
            cbSiteName.Items.Clear();
            cbSiteLogin.Items.Clear();
            tbLogin.Text = "";
            tbMail.Text = "";
            tbPassword.Text = "";
            loadSites();
            cbSiteName.SelectedIndex = cbSiteName.Items.Count < 1 ? -1 : 0; 
            cbSiteLogin.SelectedIndex = cbSiteLogin.Items.Count < 1 ? -1 : 0;
        }

        private void Form1_Resize(object sender, EventArgs e)
        {
            if (this.WindowState == FormWindowState.Minimized)
            {
                this.Hide();
            }
        }


        private void tsmiClose_Click(object sender, EventArgs e)
        {
            if ((CheckIfFileIsBeingUsed("saver.dat") == true) && (File.Exists("saver.dat"))) //Файл существует, но занят другим приложением
            {
                MessageBox.Show(Messages[9], Messages[10]);
                saveArray("Error/saver " + DateTime.Now.ToString() + ".dat");
            }
            else
            {
                saveArray("saver.dat", "OnClosing");
            }
            Thread.Sleep(600);
            this.WindowState = FormWindowState.Minimized;
            this.ShowInTaskbar = false;
            Application.Exit();
        }

        private void Form_Resize(object sender, EventArgs e)
        {
            if (this.WindowState == FormWindowState.Minimized)
            {
                this.Hide();
                notifyIcon.Visible = true;
            }
        }

        private void Form1_FormClosing(object sender, FormClosingEventArgs e)
        {
            if(e.CloseReason.ToString()== "UserClosing")
            e.Cancel = true;
            this.WindowState = FormWindowState.Minimized;
            this.ShowInTaskbar = false;
        }

        private void notifyIcon_MouseClick(object sender, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Right) return;
            this.Show();
            notifyIcon.Visible = true;
            this.ShowInTaskbar = true;
            this.Activate();
            this.WindowState = FormWindowState.Normal;
        }

        private void rbTopMost_Click(object sender, EventArgs e)
        {
            if (TopMost) rbTopMost.Checked = false;
            else rbTopMost.Checked = true;
            TopMost = !TopMost;
        }
    }
}

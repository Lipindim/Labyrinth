using Labyrinth.Levels;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Labyrinth
{
    public partial class MasterForm : Form
    {
        private UserControl currentLevel;
        private int numberCurrentLevel;
        private List<Type> listLevelType;

        public MasterForm()
        {
            InitializeComponent();
        }

        private void TestForm_Load(object sender, EventArgs e)
        {
            listLevelType = GetListTypeLevels();
            numberCurrentLevel = 0;
            StartGame();
        }

        
        private void StartGame()
        {
            currentLevel = GetCurrentLevel();

            LoadCurrentLevel(currentLevel);

            Cursor.Position = GetStartPosition(currentLevel);

            AddEventsMouseEnter(currentLevel);

            PlaySound.PlayMusic(Sound.start);
        }

        private void restartGame()
        {
            PlaySound.PlayMusic(Sound.fail);
            if (MessageBox.Show("Вы проиграли! Ещё разок?", "Неудача...", MessageBoxButtons.YesNo) == System.Windows.Forms.DialogResult.Yes)
            {
                StartGame();
            }
            else
            {
                this.Close();
            }
        }

        private void finishGame()
        {
            numberCurrentLevel++;
            if (numberCurrentLevel == listLevelType.Count)
            {
                PlaySound.PlayMusic(Sound.victory);
                MessageBox.Show("Вы прошли лабиринт! Поздравляю!!!");
                this.Close();
            }
            else
            {
                PlaySound.PlayMusic(Sound.finish);
                MessageBox.Show("Уровень пройден!");
                StartGame();
            }

        }


        private void control_MouseEnter(object sender, EventArgs e)
        {
            if (sender is Wall || sender is Flashing_wall)
            {
                restartGame();
            }
            if (sender is Finish)
            {
                finishGame();
            }
            if (sender is Key)
            {
                (sender as Key).Visible = false;
                PlaySound.PlayMusic(Sound.key);
            }
            if (sender is Door)
            {
                checkKey(sender);
            }
            if (sender is Ice)
            {
                DanceMouse();
            }

        }
       

        private void AddEventsMouseEnter(UserControl currentLevel)
        {
            foreach (Control _control in currentLevel.Controls)
            {
                _control.MouseEnter += control_MouseEnter;
            }
        }
        private static void DanceMouse()
        {
            Random rnd = new Random();
            int MAX_OFFSET = 15;
            int _xOffset = rnd.Next(MAX_OFFSET * 2);
            Thread.Sleep(10);
            int _yOffset = rnd.Next(MAX_OFFSET * 2);
            Point _currentPosition = Cursor.Position;
            _currentPosition.Offset(_xOffset - MAX_OFFSET, _yOffset - MAX_OFFSET);
            Cursor.Position = _currentPosition;
        }
        private void checkKey(object sender)
        {
            Key _key = (Key)(from key in currentLevel.Controls.Cast<UserControl>()
                             where key is Key && key.BackColor == (sender as Door).BackColor
                             select key).FirstOrDefault();
            if (_key.Visible)
            {
                restartGame();
            }
            else
            {
                PlaySound.PlayMusic(Sound.key);
                (sender as Door).Visible = false;
            }
        }
        private Point GetStartPosition(UserControl aCurrentLevel)
        {
            Start _start = (Start)(from start in aCurrentLevel.Controls.Cast<Control>()
                                   where start is Start
                                   select start).FirstOrDefault();

            Point _startPoint = _start.Location;
            _startPoint.Offset(_start.Width / 2, _start.Height / 2);
            return PointToScreen(_startPoint);
        }
        private static List<Type> GetListTypeLevels()
        {
            return (from type in Assembly.GetExecutingAssembly().GetTypes()
                    where type.BaseType == typeof(UserControl) && type.Name.Contains("Level")
                    orderby type.Name
                    select type).ToList();
        }
        private UserControl GetCurrentLevel()
        {
            ConstructorInfo _levelConstructor = listLevelType[numberCurrentLevel].GetConstructors().FirstOrDefault();
            UserControl currentLevel = (UserControl)_levelConstructor.Invoke(null);
            return currentLevel;
        }
        private void LoadCurrentLevel(UserControl currentLevel)
        {
            this.Controls.Clear();
            this.Controls.Add(currentLevel);
            this.Size = currentLevel.Size;
        }
    }
}

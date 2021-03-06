﻿using GameLogic.TetrisObjects;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows;

namespace GameLogic
{
    public class GameManager
    {

        private List<Point> listOfAllPoints = new List<Point>();
        private IObject movingObject;
        private IObject nextMovingObject;
        private bool isEndOfGame = false;
        private Thread th;
        private Random ran = new Random();
        private int level = 0;
        private int score = 0;
        private int timeOut = 1000;


        public static int Columns { get { return 10; } }
        public static int Rows { get { return 20; } }
        public BaseShapeObject MovingObject { get { return (BaseShapeObject)movingObject; } }
        public BaseShapeObject NextMovingObject { get { return (BaseShapeObject)nextMovingObject; } }
        public int Level { get { return level; } }
        public int Score { get { return score; } }
        public bool IsEndOfGame { get { return isEndOfGame; } }
        public bool IsPaused { get; set; }

        public delegate void MoveDownByThHandler();
        public event MoveDownByThHandler MoveDownByThread;


        /// <summary>
        /// starts the game
        /// </summary>
        public void Start()
        {
            AddNewObject();
            th = new Thread(MoveDownByTh);
            th.IsBackground = false;
            th.Start();
        }

        private void MoveDownByTh()
        {
            while (true)
            {
                if (isEndOfGame) th.Abort();
                if (!IsPaused) if (MoveDownByThread != null) MoveDownByThread();
                Thread.Sleep(timeOut);
            }
        }


        /// <summary>
        /// add new object into the game
        /// </summary>
        public void AddNewObject()
        {
            if (movingObject != null) listOfAllPoints.AddRange(((BaseShapeObject)movingObject).Points);
            CheckRows();
            if (nextMovingObject == null)
            {
                CreateNewNextObject();
            }
            movingObject = nextMovingObject;
            if (((BaseShapeObject)movingObject).Collision(GetAllPoints()))
            {
                isEndOfGame = true;
                ShowGameOver();
            }
            CreateNewNextObject();
        }



        /// <summary>
        /// creates a new object that will follow the current one
        /// </summary>
        private void CreateNewNextObject()
        {
            nextMovingObject = GetRandomObject();
            nextMovingObject.Create(Columns / 2, 0);
        }


        private IObject GetRandomObject()
        {
            switch (ran.Next(0, 7))
            {
                case 0:
                    {
                        return new ObjectO();
                    }
                case 1:
                    {
                        return new ObjectI();
                    }
                case 2:
                    {
                        return new ObjectL();
                    }
                case 3:
                    {
                        return new ObjectZ();
                    }
                case 4:
                    {
                        return new ObjectT();
                    }
                case 5:
                    {
                        return new ObjectJ();
                    }
                case 6:
                    {
                        return new ObjectS();
                    }
            }
            return new ObjectO();
        }


        /// <summary>
        /// checks rows whether they shall be removed + score adding
        /// </summary>
        private void CheckRows()
        {
            int delRows = 0;
            List<Point> pointsToDel = new List<Point>();
            for (int i = 0; i < GameManager.Rows; i++)
            {
                pointsToDel = listOfAllPoints.Where(p => p.Y == i).ToList();
                if (pointsToDel.Count() >= GameManager.Columns)
                {
                    pointsToDel.ForEach(p => listOfAllPoints.Remove(p));
                    listOfAllPoints.ForEach(p => { if (p.Y < i) p.Y++; });
                    delRows++;
                }
            }
            if (delRows > 0)
            {
                switch (delRows)
                {
                    case 1:
                        score += delRows * 40 + 40;
                        break;
                    case 2:
                        score += delRows * 100 + 100;
                        break;
                    case 3:
                        score += delRows * 300 + 300;
                        break;
                    case 4:
                        score += delRows * 1200 + 1200;
                        break;
                }
                if (score >= ((level + 1) * 3000) * 3 / 2) NewLevel();

            }

            /*
Count of removed rows	Formula
One	    n*40 + 40
Two	    n*100 + 100
Three	n*300 + 300
Four (tetris)	n*1200 + 1200
              * */
        }

        private void NewLevel()
        {
            level++;
            //    listOfAllPoints.Clear();
            //    movingObject = null;
            AddNewObject();
            timeOut = (int)(timeOut * 0.8F);

        }


        /// <summary>
        /// all non-moving points
        /// </summary>
        /// <returns></returns>
        public List<Point> GetAllPoints()
        {
            return listOfAllPoints;
        }

        #region moves


        /// <summary>
        /// move object right
        /// </summary>
        public void MoveToRight()
        {
            if (IsPaused) return;
            MovingObject.MoveToRight(GetAllPoints());

        }
        /// <summary>
        /// move object left
        /// </summary>
        public void MoveToLeft()
        {
            if (IsPaused) return;
            MovingObject.MoveToLeft(GetAllPoints());
        }

        /// <summary>
        /// move object down
        /// </summary>
        public void MoveToDown()
        {
            if (IsPaused) return;
            if (!MovingObject.MoveDown(GetAllPoints()))
            {
                AddNewObject();
            }
        }

        /// <summary>
        /// rotate object
        /// </summary>
        public void Rotate()
        {
            if (IsPaused) return;
            MovingObject.Rotate(GetAllPoints());
        }

        #endregion

        public void EndRunningGame()
        {
            th.Abort();
        }

        /// <summary>
        /// displays game over text in the gaming space
        /// </summary>
        private void ShowGameOver()
        {
            MessageBox.Show(" Game Over! \n Start new game? \n", "GAME OVER", MessageBoxButton.YesNo, MessageBoxImage.None);
            EndRunningGame();
            
            //ObjectGO ogo = new ObjectGO();
            //ogo.Create(Columns / 2, 0);
            ////   listOfAllPoints.AddRange();
            //List<int> indexes = new List<int>();
            //foreach (Point point in ((BaseShapeObject)(ogo)).Points)
            //{
            //    Point pp = listOfAllPoints.FirstOrDefault(p => p.X == point.X && p.Y == point.Y);
            //    if (pp != null) listOfAllPoints.Remove(pp);
            //    listOfAllPoints.Add(point);

            //    // indexes.AddRange((listOfAllPoints.IndexOf(p => p.X == point.X && p.Y == point.Y)));
            //}
            //   listOfAllPoints.ForEach(p=>p.);
        }


    }
}

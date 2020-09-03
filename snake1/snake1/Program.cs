﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace snake1
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.SetWindowSize(1, 1);
            Console.SetBufferSize(80, 25);
            Console.SetWindowSize(80, 25);

            VerticalLine v1 = new VerticalLine(0, 10, 5, '&');
           // Draw(v1);

            Point p = new Point(4, 5, '*');
            figure fsnace = new Snake(p, 4, Direction.RIGHT);
           // Draw(fsnace);
            Snake snake = (Snake)fsnace;

            HorizontalLine h1 = new HorizontalLine(0,5, 6, '*');

            List<figure> figures = new List<figure>();
figures.Add(fsnace);
            figures.Add(v1);
           
            figures.Add(h1);
            // figures.Add(snake);

            foreach (var f in figures)
            {
                Draw(f);
                f.Drow();
            }

            /*
            //ramka
            HorizontalLine upline = new HorizontalLine(0, 78, 0, '+');
            HorizontalLine downline = new HorizontalLine(0, 78, 24, '+');
            VerticalLine leftline = new VerticalLine(0, 24, 0, '+');
            VerticalLine rightline = new VerticalLine(0, 24, 78, '+');
            upline.Drow();
            downline.Drow();
            leftline.Drow();
            rightline.Drow();
            
            Point p = new Point(4,5, '+');
            Snake snake = new Snake(p, 4, Direction.RIGHT);
            snake.Drow();


            FoodCreator foodCreator = new FoodCreator(80, 25,'$');
            Point food = foodCreator.CreateFood();
            food.Drow();

            while (true)
            {
                if(snake.Eat(food))
                {
                    food = foodCreator.CreateFood();
                    food.Drow();
                }
                else
                {
                    snake.Move();
                }
                Thread.Sleep(200);
    
            // while (true)
            // {
            if (Console.KeyAvailable)
                   {
                  ConsoleKeyInfo key = Console.ReadKey();
                    snake.HandleKey(key.Key);
                   }
         // Thread.Sleep(100);
          // snake.Move();
            }

//Console.ReadLine();*/
            Console.ReadLine();
        }
 
        static void Draw(figure figure)
            {
            figure.Drow();
            
        }
        
    } 

}


using System;
using System.Collections.Generic;
using System.Linq;

namespace backjun
{
    public class Bowling
    {
        private (int, int, int, int)[] m_score;
        private List<Action<int>> m_action = new();
        private int m_frame;
        private int m_ballCount;
        private int m_prevPin;
        private const int STRIKE = 10;
        private const int SPARE = 10;
        private const int LAST_FRAME = 9;

        public Bowling()
        {
            m_score = new (int, int, int, int)[10];
            m_frame = 0;
            m_ballCount = 0;
            m_prevPin = 0;
        }

        public void ThrowBall(char pin)
        {
            var pinScore = InputScore(pin);
            m_prevPin = pinScore;
            var frame = m_frame;

            if (m_ballCount == 0)
            {
                m_score[m_frame].Item1 = pinScore;
            }
            else if (m_ballCount == 1)
            {
                m_score[m_frame].Item2 = pinScore;
            }
            else
            {
                m_score[m_frame].Item3 = pinScore;
            }

            m_score[m_frame].Item4 += pinScore;
            m_ballCount++;

            foreach (var func in m_action.ToList())
            {
                func.Invoke(pinScore);
                m_action.Remove(func);
            }

            if (m_frame < LAST_FRAME)
            {
                if (m_score[m_frame].Item1 == STRIKE)
                {
                    m_action.Add(pin => 
                    { 
                        m_score[frame].Item4 += pin;

                        m_action.Add(pin => m_score[frame].Item4 += pin);
                    });
                }
                else if (m_score[m_frame].Item1 + m_score[m_frame].Item2 == SPARE)
                {
                    m_action.Add(pin => m_score[frame].Item4 += pin);
                }

                if (pinScore == 10 || m_ballCount == 2)
                {
                    m_frame++;
                    m_ballCount = 0;
                    m_prevPin = 0;
                }
            }
        }

        private int InputScore(char pin)
        {
            int add;

            if (pin == 'S')
            {
                add = 10;
            }
            else if (pin == 'P')
            {
                add = 10 - m_prevPin;
            }
            else if (pin == '-')
            {
                add = 0;
            }
            else
            {
                add = Int32.Parse(pin.ToString());
            }

            return add;
        }

        public int TotalScore()
        {
            int sum = 0;

            foreach (var i in m_score)
            {
                sum += i.Item4;
            }

            return sum;
        }
    }

    public class Program
    {
        static void Main(string[] args)
        {
            string inputs = Console.ReadLine();

            Bowling bowling = new Bowling();

            for (int i = 0; i < inputs.Length; i++)
            {
                bowling.ThrowBall(inputs[i]);
            }

            Console.WriteLine(bowling.TotalScore());
        }
    }
}
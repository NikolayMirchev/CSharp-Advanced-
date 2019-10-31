using System;

namespace Problem_8._Car_Salesman
{
    public class Car
    {
        private string model;
        private Engine engine;
        private string weight = "n/a";
        private string color = "n/a";

        public string Model { get => model; set => model = value; }
        public Engine Engine { get => engine; set => engine = value; }
        public string Weight { get => weight; set => weight = value; }
        public string Color { get => color; set => color = value; }
    }
}

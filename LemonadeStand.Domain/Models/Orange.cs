﻿using LemonadeStand.Domain.Interfaces;

namespace LemonadeStand.Domain.Models
{
    public class Orange : IFruit
    {
        public string Name { get; } = "Orange";
    }
}
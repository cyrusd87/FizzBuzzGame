﻿using FizzBuzzGame.Model;

namespace FizzBuzzGame.Presenter
{
    public interface IOutputWriterVisitor
    {
        void Visit(NumberFormat input);
        void Visit(FizzFormat input);
        void Visit(BuzzFormat input);
        void Visit(FizzBuzzFormat input);

    }
}

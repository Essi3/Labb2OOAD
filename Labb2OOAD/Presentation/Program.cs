using System;
using Labb2OOAD.Presentation;
using Labb2OOAD.Services;

namespace Labb2OOAD
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Press any key to see how many people are in space today");
            Console.ReadKey();

            ViewModel viewModel = new ViewModel(new ApiService());
            viewModel.Load();
        }
    }
}
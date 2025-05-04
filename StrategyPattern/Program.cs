// See https://aka.ms/new-console-template for more information

using StrategyPattern;

int[] array = [7,8,1,6,8,6] ; 
var context = new Context() ; 
context.SetMethod(new QuickSort());
context.ApplayMethod(array);

// switch method

context.SetMethod(new BubbleSort());
context.ApplayMethod(array);
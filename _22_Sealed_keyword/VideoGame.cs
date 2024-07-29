namespace _22_Sealed_keyword;

//internal sealed class VideoGame : Game
/*
 * prevent the inheritance: It could be a class as method level.
 */
public class VideoGame : Game
{
    public override void WhatIsCool()
    {
        Console.WriteLine("This VideoGame is cool!");
    }
}
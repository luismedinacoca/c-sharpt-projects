namespace _22_Sealed_keyword;

class Program
{
    static void Main(string[] args)
    {
        // Setup some objects:
        Game game = new Game();
        VideoGame vg = new VideoGame();
        SuperMario sm = new SuperMario();

        game.WhatIsCool();
        vg.WhatIsCool();
        sm.WhatIsCool();
    }
}
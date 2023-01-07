Console.WriteLine("how many people are we making PB&J sandwiches for?");
string numberOfPeeps = Console.ReadLine();
int numberOfPeeps2 = Int32.Parse(numberOfPeeps);

double slices = (numberOfPeeps2 * 2);
double pbSpoons = (numberOfPeeps2 * 2);
double jellySpoons = (numberOfPeeps2 * 4);

double loaves = (slices / 28);
double pbJars = (pbSpoons / 32);
double jellyJars = (jellySpoons / 48);

double loavesRounded = Math.Ceiling(loaves);
double pbJarsRounded = Math.Ceiling(pbJars);
double jellyJarsRounded = Math.Ceiling(jellyJars);

Console.WriteLine("\n\nyou need:\n\n");

Console.WriteLine(slices + " slices of bread\n");
Console.WriteLine(pbSpoons + " tablespoons of peanut butter\n");
Console.WriteLine(jellySpoons + " teaspoons of jelly\n\n");

Console.WriteLine("which is...\n\n");

Console.WriteLine(loavesRounded + " loaves of bread\n");
Console.WriteLine(pbJarsRounded + " jar/s of peanut butter\n");
Console.WriteLine(jellyJarsRounded + " jar/s of jelly\n\n");

Console.WriteLine("Would you like to restart? Enter yes or y to continue, or enter any other key to exit.");
string response = Console.ReadLine();

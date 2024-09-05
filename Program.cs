using MonsterModellering;

MegaMan man = new MegaMan() {
    Name = "Rockman",
    HitPoints = 100
};
MegaMan zero = new MegaMan();

zero.Name = "Zero";

Console.WriteLine(man.Name);

Console.ReadLine();
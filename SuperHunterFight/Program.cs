// See https://aka.ms/new-console-template for more information
using SuperHunterFight.Objects;
using SuperHunterFight.Objects.Behavior;
using SuperHunterFight.Objects.Children;

Console.WriteLine("Hunt!!");

Hunter hunter = new Hunter("Elmer");
Weapon gun = new Shotgun("shotgun", "nice btw", 50);
LivingBeing monke = new Monke("jorge","es curioso",60);

hunter.Shoot(gun, monke);

Console.WriteLine("El cazador dispara y.... " + (monke.IsAlive() ? "Sobrevivio" : "Murio!"));


LivingBeing dinosaur = new Dinosaur("Miguel", "Es un dinosaurio", 3123123123f, 123123f);
Console.WriteLine("La vida de " + dinosaur.Name + " es: " + dinosaur.Health);



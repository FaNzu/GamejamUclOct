using GamejamCheese.Controller;
using GamejamCheese.View;
using Spectre.Console;
using GamejamCheese.Models;
namespace GamejamCheese
{
	internal class Program
	{
		static void Main(string[] args)
		{
			//New Connections
			Connection LandingZoneToTheMartian = new Connection();
			Connection TheMartianToDoctorZed = new Connection();

			//New sections
			Section MarsOrbit = new Section("Mars", "This planet has no form of life", "Scan planet for lifeforms", Modifier.LowGravity);
			Section MarsLandingZone = new Section("Mars landing zone", "This landing zone does not seem safe....", "Refuel ship", Modifier.HighGravity);
			Section TheMartian = new Section("The Martian", "This planet has no form of life", "Ask for roumers", Modifier.HighGravity);
			Section DoctorZed = new Section("Doctor Zed", "This planet has no form of life", "Ask Doctor Zed to patch you op", Modifier.HighGravity);

			Connection MarsOrbitToLandingZone = new Connection();


			//Connecting sections
			MarsOrbitToLandingZone.NextSection = MarsLandingZone;
			MarsOrbitToLandingZone.LastSection = MarsOrbit;
			MarsOrbitToLandingZone.IsVisible = true;

			MarsOrbit.Connections.Add(MarsOrbitToLandingZone);

			LandingZoneToTheMartian.NextSection = TheMartian;
			LandingZoneToTheMartian.LastSection = MarsLandingZone;
			LandingZoneToTheMartian.IsVisible = true;

			MarsLandingZone.Connections.Add(LandingZoneToTheMartian);

			TheMartianToDoctorZed.NextSection = DoctorZed;
			TheMartianToDoctorZed.LastSection = TheMartian;
			TheMartianToDoctorZed.IsVisible = true;

			TheMartian.Connections.Add(TheMartianToDoctorZed);

			//Starting the game at mars orbit
			SectionController.StartSection(MarsOrbit);
			Console.ReadLine();
		}
	}
}
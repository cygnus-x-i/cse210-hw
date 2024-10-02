using System;

class Program
{
    static void Main(string[] args)
    {
        Costume nurse = new();
        nurse.headWear = "Face mask";
        nurse.gloves = "Latex";
        nurse.shoes = "Orthopedic sneakers";
        nurse.upperGarment = "Scrubs";
        nurse.lowerGarment = "Scrubs";
        nurse.accessory = "Stethoscope";


        Costume detective = new();
        detective.headWear = "Fedora";
        detective.gloves = "Leather";
        detective.shoes = "Loafers";
        detective.upperGarment = "Trench coat";
        detective.lowerGarment = "Slacks";
        detective.accessory = "Magnifying glass";

        nurse.showWardrobe();
        detective.showWardrobe();
    }
}
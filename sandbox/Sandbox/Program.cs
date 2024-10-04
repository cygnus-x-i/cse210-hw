using System;

class Program
{
    static void Main(string[] args)
    {
        Costume nurse = new();
        nurse._headWear = "Face mask";
        nurse._gloves = "Latex";
        nurse._shoes = "Orthopedic sneakers";
        nurse._upperGarment = "Scrubs";
        nurse._lowerGarment = "Scrubs";
        nurse._accessory = "Stethoscope";


        Costume detective = new();
        detective._headWear = "Fedora";
        detective._gloves = "Leather";
        detective._shoes = "Loafers";
        detective._upperGarment = "Trench coat";
        detective._lowerGarment = "Slacks";
        detective._accessory = "Magnifying glass";

        nurse.showWardrobe();
        detective.showWardrobe();
    }
}
using System;
using System.Collections.Generic;

public class Dough
{
    public KeyValuePair<string, double> Flour { get; set; }

    public KeyValuePair<string, double> BakingTechnique { get; set; }

    public double Weight { get; set; }

    public double Calories => (2 * Weight) * Flour.Value * BakingTechnique.Value;

    public Dough(string input)
    {
        var flours = new Dictionary<string, double>();
        flours.Add("white", 1.5);
        flours.Add("wholegrain", 1.0);

        var techniques = new Dictionary<string, double>();
        techniques.Add("crispy", 0.9);
        techniques.Add("chewy", 1.1);
        techniques.Add("homemade", 1);


        var details = input.Split();

        var flour = details[1];
        if (!flours.ContainsKey(flour.ToLower()))
            throw new Exception("Invalid type of dough.");
        Flour = new KeyValuePair<string, double>(flour, flours[flour.ToLower()]);

        var technique = details[2];
        if (!techniques.ContainsKey(technique.ToLower()))
            throw new Exception("Invalid type of dough.");
        BakingTechnique = new KeyValuePair<string, double>(technique, techniques[technique.ToLower()]);

        var weight = double.Parse(details[3]);
        if (weight < 1 || weight > 200)
            throw new Exception("Dough weight should be in the range [1..200].");
        Weight = weight;
    }

    public Dough()
    {

    }


}

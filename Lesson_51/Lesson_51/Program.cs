byte aggression = 1;
byte democracyModifier = 2;

aggression = (byte)(aggression - democracyModifier); // вот такой был баг в цыве, переполнение
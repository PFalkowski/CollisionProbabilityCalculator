using System.Numerics;

var numberOfRecords = 100_000;
int[] bitLengths = [128, 96, 64, 48, 32, 24];

PrintResults(numberOfRecords, bitLengths);
return;

static (double probabilityOfCollision, BigInteger totalPossibleValues) Calculate(int numberOfRecords, int bitLength)
{
    // Calculate total possible values (2^bitLength)
    var m = BigInteger.Pow(2, bitLength);

    // Calculate probability of no collision
    var exponent = -((double)numberOfRecords * (numberOfRecords - 1)) / (2 * (double)m);
    var probabilityOfNoCollision = Math.Exp(exponent);

    // Probability of at least one collision
    var probabilityOfCollision = 1 - probabilityOfNoCollision;

    return (probabilityOfCollision, m);
}

static void PrintResults(int numberOfRecords, int[] bitLengths)
{
    Console.WriteLine($"Collision probabilities for {numberOfRecords:N0} records:");
    Console.WriteLine("Bit Length | Probability of Collision | Total Possible Values");
    Console.WriteLine("---------------------------------------------------------------");

    foreach (var bitLength in bitLengths)
    {
        var (probability, totalValues) = Calculate(numberOfRecords, bitLength);
        Console.WriteLine($"{bitLength,10} | {probability,25:P15} | {totalValues,20:N0}");
    }
}

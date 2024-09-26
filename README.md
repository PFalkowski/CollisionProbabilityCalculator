# Collision Probability Calculator

## Overview

The Collision Probability Calculator isdesigned to analyze the probability of collisions of unique identifiers, such as GUIDs or custom short IDs. It calculates the likelihood of a collision occurring for a given number of records and bit length of the identifier.

## Features

- Calculates collision probability for a specified number of records and bit length
- Computes the total possible values for a given bit length
- Provides a tabular output for easy comparison of different bit lengths

## Understanding the Output

The program outputs a table with the following columns:

1. **Bit Length**: The number of bits used for the identifier
2. **Probability of Collision**: The likelihood of at least one collision occurring
3. **Total Possible Values**: The total number of unique identifiers possible with this bit length

Example output:

```
Collision probabilities for 100,000 records:
Bit Length | Probability of Collision | Total Possible Values
---------------------------------------------------------------
       128 |                0.000000% |  340,282,366,920,938,463,463,374,607,431,768,211,456
        96 |                0.000000% |    79,228,162,514,264,337,593,543,950,336
        64 |                0.000027% |            18,446,744,073,709,551,616
        48 |                0.179454% |                   281,474,976,710,656
        32 |               68.665785% |                     4,294,967,296
        24 |               99.999981% |                        16,777,216
```

## Recommendations

- For critical systems where uniqueness is paramount, stick with 128-bit GUIDs.
- For systems requiring shorter identifiers but still needing very high uniqueness, consider 96-bit or 64-bit identifiers.
- Avoid using 32-bit or shorter identifiers for large datasets, as the collision approaches 1 quickly.

## Limitations

- The calculator uses the birthday problem formula, which provides an upper bound on the collision probability.
- Real-world collision rates may be lower depending on the quality of the random number generator used.
- The program assumes uniform random distribution of identifiers.

## Contributing

Feel free to fork this project and submit pull requests for any enhancements or bug fixes. If you encounter any issues or have suggestions, please open an issue in the project repository.

| Method                                      | N   |            Mean |           Error |          StdDev |          Median |  Ratio | RatioSD |
|---------------------------------------------|-----|----------------:|----------------:|----------------:|----------------:|-------:|--------:|
| 'Linear Multiply'                           | 2   |        713.1 ns |        13.59 ns |        22.33 ns |        701.4 ns |   1.00 |    0.00 |
| 'Async Per Cell Multiply'                   | 2   |      2,908.5 ns |        65.74 ns |       193.83 ns |      2,840.1 ns |   4.24 |    0.27 |
| 'Async Per Row Multiply'                    | 2   |      2,232.3 ns |        18.47 ns |        16.37 ns |      2,233.4 ns |   3.08 |    0.09 |
| '[Threads = 1] Thread Per Row Multiply'     | 2   |    141,676.4 ns |       979.26 ns |       868.09 ns |    141,451.8 ns | 195.70 |    6.16 |
| '[Threads = N / 2] Thread Per Row Multiply' | 2   |    141,364.3 ns |       666.30 ns |       556.39 ns |    141,217.7 ns | 194.70 |    6.64 |
| '[Threads = N] Thread Per Row Multiply'     | 2   |    236,748.9 ns |     1,803.17 ns |     1,598.46 ns |    236,485.4 ns | 327.06 |   11.66 |
|                                             |     |                 |                 |                 |                 |        |         |
| 'Linear Multiply'                           | 5   |      4,296.4 ns |        12.95 ns |        12.12 ns |      4,296.5 ns |   1.00 |    0.00 |
| 'Async Per Cell Multiply'                   | 5   |      8,263.5 ns |       164.58 ns |       378.14 ns |      8,180.4 ns |   1.92 |    0.09 |
| 'Async Per Row Multiply'                    | 5   |      7,285.0 ns |       140.85 ns |       156.56 ns |      7,294.8 ns |   1.70 |    0.04 |
| '[Threads = 1] Thread Per Row Multiply'     | 5   |    142,443.3 ns |     1,827.30 ns |     1,619.86 ns |    141,859.7 ns |  33.17 |    0.34 |
| '[Threads = N / 2] Thread Per Row Multiply' | 5   |    240,244.5 ns |     1,928.88 ns |     1,505.94 ns |    240,347.6 ns |  55.93 |    0.37 |
| '[Threads = N] Thread Per Row Multiply'     | 5   |    525,042.5 ns |     1,127.54 ns |       999.54 ns |    525,046.7 ns | 122.25 |    0.38 |
|                                             |     |                 |                 |                 |                 |        |         |
| 'Linear Multiply'                           | 10  |     22,954.9 ns |       113.22 ns |       105.91 ns |     22,933.2 ns |   1.00 |    0.00 |
| 'Async Per Cell Multiply'                   | 10  |     23,967.3 ns |       126.72 ns |       118.53 ns |     23,952.7 ns |   1.04 |    0.01 |
| 'Async Per Row Multiply'                    | 10  |     14,350.3 ns |       107.25 ns |       100.32 ns |     14,371.0 ns |   0.63 |    0.00 |
| '[Threads = 1] Thread Per Row Multiply'     | 10  |    164,038.6 ns |     1,154.08 ns |     1,023.06 ns |    164,162.3 ns |   7.14 |    0.05 |
| '[Threads = N / 2] Thread Per Row Multiply' | 10  |    536,878.9 ns |       937.35 ns |       830.94 ns |    536,901.1 ns |  23.38 |    0.09 |
| '[Threads = N] Thread Per Row Multiply'     | 10  |  1,030,847.1 ns |     4,916.25 ns |     4,598.67 ns |  1,030,001.2 ns |  44.91 |    0.26 |
|                                             |     |                 |                 |                 |                 |        |         |
| 'Linear Multiply'                           | 100 | 12,170,328.7 ns |   240,711.10 ns |   367,591.28 ns | 12,077,534.4 ns |   1.00 |    0.00 |
| 'Async Per Cell Multiply'                   | 100 |  9,260,326.9 ns |    92,759.82 ns |    86,767.59 ns |  9,252,940.6 ns |   0.75 |    0.03 |
| 'Async Per Row Multiply'                    | 100 |  4,100,536.2 ns |    46,243.54 ns |    40,993.69 ns |  4,108,462.5 ns |   0.33 |    0.01 |
| '[Threads = 1] Thread Per Row Multiply'     | 100 | 12,200,412.8 ns |    28,938.08 ns |    27,068.70 ns | 12,195,131.2 ns |   0.99 |    0.03 |
| '[Threads = N / 2] Thread Per Row Multiply' | 100 |  6,886,974.7 ns |    96,122.16 ns |    85,209.79 ns |  6,871,453.1 ns |   0.56 |    0.02 |
| '[Threads = N] Thread Per Row Multiply'     | 100 | 11,981,321.6 ns |   229,767.42 ns |   282,175.02 ns | 11,885,775.8 ns |   0.97 |    0.04 |
|                                             |     |                 |                 |                 |                 |        |         |
| 'Linear Multiply'                           | 200 | 86,279,151.1 ns |   790,910.80 ns |   739,818.45 ns | 85,941,400.0 ns |   1.00 |    0.00 |
| 'Async Per Cell Multiply'                   | 200 | 70,615,561.1 ns | 1,380,810.26 ns | 2,559,420.36 ns | 70,333,314.3 ns |   0.81 |    0.03 |
| 'Async Per Row Multiply'                    | 200 | 28,815,371.0 ns |   161,833.55 ns |   143,461.23 ns | 28,828,070.3 ns |   0.33 |    0.00 |
| '[Threads = 1] Thread Per Row Multiply'     | 200 | 87,905,931.9 ns |   413,181.88 ns |   322,585.23 ns | 87,793,266.7 ns |   1.02 |    0.01 |
| '[Threads = N / 2] Thread Per Row Multiply' | 200 | 34,064,145.2 ns |   225,282.06 ns |   199,706.68 ns | 34,043,256.7 ns |   0.39 |    0.00 |
| '[Threads = N] Thread Per Row Multiply'     | 200 | 41,519,573.9 ns |   828,197.09 ns | 1,047,404.14 ns | 40,975,253.8 ns |   0.49 |    0.01 |
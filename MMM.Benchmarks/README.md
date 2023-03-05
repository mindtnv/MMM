| Method                    | N   |           Mean |         Error |         StdDev | Ratio | RatioSD |
|---------------------------|-----|---------------:|--------------:|---------------:|------:|--------:|
| 'Linear Multiply'         | 5   |       4.231 us |     0.0142 us |      0.0111 us |  1.00 |    0.00 |
| 'Async Per Cell Multiply' | 5   |       8.256 us |     0.1616 us |      0.3114 us |  1.98 |    0.08 |
| 'Async Per Row Multiply'  | 5   |       7.340 us |     0.1430 us |      0.1338 us |  1.74 |    0.03 |
|                           |     |                |               |                |       |         |
| 'Linear Multiply'         | 10  |      22.207 us |     0.0474 us |      0.0443 us |  1.00 |    0.00 |
| 'Async Per Cell Multiply' | 10  |      23.850 us |     0.2623 us |      0.2325 us |  1.07 |    0.01 |
| 'Async Per Row Multiply'  | 10  |      14.559 us |     0.2328 us |      0.2063 us |  0.66 |    0.01 |
|                           |     |                |               |                |       |         |
| 'Linear Multiply'         | 100 |  11,397.826 us |    26.1585 us |     23.1889 us |  1.00 |    0.00 |
| 'Async Per Cell Multiply' | 100 |   9,265.521 us |    81.8318 us |     76.5456 us |  0.81 |    0.01 |
| 'Async Per Row Multiply'  | 100 |   4,021.301 us |    50.5615 us |     47.2952 us |  0.35 |    0.00 |
|                           |     |                |               |                |       |         |
| 'Linear Multiply'         | 400 | 641,912.671 us | 1,837.9984 us |  1,629.3377 us |  1.00 |    0.00 |
| 'Async Per Cell Multiply' | 400 | 382,204.324 us | 7,506.1030 us | 12,120.9572 us |  0.60 |    0.02 |
| 'Async Per Row Multiply'  | 400 | 210,603.018 us | 1,965.6332 us |  1,641.3928 us |  0.33 |    0.00 |
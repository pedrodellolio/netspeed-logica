### A: Se a = 1; b = 2; c = 3

- Se (a < b + c) = TRUE; (b < a + c) = TRUE; (c < a + b) = FALSE
- Portanto: TRUE * TRUE * FALSE = FALSE
- Resultado: **"Não é possível formar um triângulo"**

| Passo  | Linha |  a  |  b  |  c  |                  Mensagem                   |
|--------|-------|-----|-----|-----|---------------------------------------------|
| Início |   -   |  0  |  0  |  0  | ""                                          |
| 1      |   7   |  1  |  0  |  0  | ""                                          |
| 2      |   9   |  1  |  2  |  0  | ""                                          |
| 3      |  11   |  1  |  2  |  3  | ""                                          |
| 4      |  23   |  1  |  2  |  3  | "Não é possível formar um triângulo"        |

---

### B: Se a = 3; b = 4; c = 5

- Se (a < b + c) = TRUE; (b < a + c) = TRUE; (c < a + b) = TRUE
- Portanto: TRUE * TRUE * TRUE = TRUE
- Se (a = b) = FALSE; (b = c) = FALSE
- Portanto: FALSE * FALSE = FALSE
- Se (a = b) = FALSE; (b = c) = FALSE; (a = c) = FALSE
- Portanto: FALSE + FALSE + FALSE = FALSE
- Resultado: **"Triângulo Escaleno"**

| Passo  | Linha |  a  |  b  |  c  |                  Mensagem                   |
|--------|-------|-----|-----|-----|---------------------------------------------|
| Início |   -   |  0  |  0  |  0  | ""                                          |
| 1      |   7   |  3  |  0  |  0  | ""                                          |
| 2      |   9   |  3  |  4  |  0  | ""                                          |
| 3      |  11   |  3  |  4  |  5  | ""                                          |
| 4      |  19   |  3  |  4  |  5  | "Triângulo Escaleno"                        |

---

### C: Se a = 2; b = 2; c = 4

- Se (a < b + c) = TRUE; (b < a + c) = TRUE; (c < a + b) = FALSE
- Portanto: TRUE * TRUE * FALSE = FALSE
- Resultado: **"Não é possível formar um triângulo"**

| Passo  | Linha |  a  |  b  |  c  |                  Mensagem                   |
|--------|-------|-----|-----|-----|---------------------------------------------|
| Início |   -   |  0  |  0  |  0  | ""                                          |
| 1      |   7   |  2  |  0  |  0  | ""                                          |
| 2      |   9   |  2  |  2  |  0  | ""                                          |
| 3      |  11   |  2  |  2  |  4  | ""                                          |
| 4      |  23   |  2  |  2  |  4  | "Não é possível formar um triângulo"        |

---

### D: Se a = 4; b = 4; c = 4

- Se (a < b + c) = TRUE; (b < a + c) = TRUE; (c < a + b) = TRUE
- Portanto: TRUE * TRUE * TRUE = TRUE
- Se (a = b) = TRUE; (b = c) = TRUE
- Portanto: TRUE * TRUE = TRUE
- Resultado: **"Triângulo Equilátero"**

| Passo  | Linha |  a  |  b  |  c  |                  Mensagem                   |
|--------|-------|-----|-----|-----|---------------------------------------------|
| Início |   -   |  0  |  0  |  0  | ""                                          |
| 1      |   7   |  4  |  0  |  0  | ""                                          |
| 2      |   9   |  4  |  4  |  0  | ""                                          |
| 3      |  11   |  4  |  4  |  4  | ""                                          |
| 4      |  14   |  4  |  4  |  4  | "Triângulo Equilátero"                      |

---

### E: Se a = 5; b = 3; c = 3

- Se (a < b + c) = TRUE; (b < a + c) = TRUE; (c < a + b) = TRUE
- Portanto: TRUE * TRUE * TRUE = TRUE
- Se (a = b) = FALSE; (b = c) = TRUE
- Portanto: FALSE * TRUE = FALSE
- Se (a = b) = FALSE; (b = c) = TRUE; (a = c) = FALSE
- Portanto: FALSE + TRUE + FALSE = TRUE
- Resultado: **"Triângulo Isósceles"**

| Passo  | Linha |  a  |  b  |  c  |                  Mensagem                   |
|--------|-------|-----|-----|-----|---------------------------------------------|
| Início |   -   |  0  |  0  |  0  | ""                                          |
| 1      |   7   |  5  |  0  |  0  | ""                                          |
| 2      |   9   |  5  |  3  |  0  | ""                                          |
| 3      |  11   |  5  |  3  |  3  | ""                                          |
| 4      |  17   |  5  |  3  |  3  | "Triângulo Isósceles"                       |

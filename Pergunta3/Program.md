### A: Se a = 1; b = 2; c = 3

- Se (a < b + c) = TRUE; (b < a + c) = TRUE; (c < a + b) = FALSE
- Portanto: TRUE * TRUE * FALSE = FALSE
- Resultado: **"N�o � poss�vel formar um tri�ngulo"**

| Passo  | Linha |  a  |  b  |  c  |                  Mensagem                   |
|--------|-------|-----|-----|-----|---------------------------------------------|
| In�cio |   -   |  0  |  0  |  0  | ""                                          |
| 1      |   7   |  1  |  0  |  0  | ""                                          |
| 2      |   9   |  1  |  2  |  0  | ""                                          |
| 3      |  11   |  1  |  2  |  3  | ""                                          |
| 4      |  23   |  1  |  2  |  3  | "N�o � poss�vel formar um tri�ngulo"        |

---

### B: Se a = 3; b = 4; c = 5

- Se (a < b + c) = TRUE; (b < a + c) = TRUE; (c < a + b) = TRUE
- Portanto: TRUE * TRUE * TRUE = TRUE
- Se (a = b) = FALSE; (b = c) = FALSE
- Portanto: FALSE * FALSE = FALSE
- Se (a = b) = FALSE; (b = c) = FALSE; (a = c) = FALSE
- Portanto: FALSE + FALSE + FALSE = FALSE
- Resultado: **"Tri�ngulo Escaleno"**

| Passo  | Linha |  a  |  b  |  c  |                  Mensagem                   |
|--------|-------|-----|-----|-----|---------------------------------------------|
| In�cio |   -   |  0  |  0  |  0  | ""                                          |
| 1      |   7   |  3  |  0  |  0  | ""                                          |
| 2      |   9   |  3  |  4  |  0  | ""                                          |
| 3      |  11   |  3  |  4  |  5  | ""                                          |
| 4      |  19   |  3  |  4  |  5  | "Tri�ngulo Escaleno"                        |

---

### C: Se a = 2; b = 2; c = 4

- Se (a < b + c) = TRUE; (b < a + c) = TRUE; (c < a + b) = FALSE
- Portanto: TRUE * TRUE * FALSE = FALSE
- Resultado: **"N�o � poss�vel formar um tri�ngulo"**

| Passo  | Linha |  a  |  b  |  c  |                  Mensagem                   |
|--------|-------|-----|-----|-----|---------------------------------------------|
| In�cio |   -   |  0  |  0  |  0  | ""                                          |
| 1      |   7   |  2  |  0  |  0  | ""                                          |
| 2      |   9   |  2  |  2  |  0  | ""                                          |
| 3      |  11   |  2  |  2  |  4  | ""                                          |
| 4      |  23   |  2  |  2  |  4  | "N�o � poss�vel formar um tri�ngulo"        |

---

### D: Se a = 4; b = 4; c = 4

- Se (a < b + c) = TRUE; (b < a + c) = TRUE; (c < a + b) = TRUE
- Portanto: TRUE * TRUE * TRUE = TRUE
- Se (a = b) = TRUE; (b = c) = TRUE
- Portanto: TRUE * TRUE = TRUE
- Resultado: **"Tri�ngulo Equil�tero"**

| Passo  | Linha |  a  |  b  |  c  |                  Mensagem                   |
|--------|-------|-----|-----|-----|---------------------------------------------|
| In�cio |   -   |  0  |  0  |  0  | ""                                          |
| 1      |   7   |  4  |  0  |  0  | ""                                          |
| 2      |   9   |  4  |  4  |  0  | ""                                          |
| 3      |  11   |  4  |  4  |  4  | ""                                          |
| 4      |  14   |  4  |  4  |  4  | "Tri�ngulo Equil�tero"                      |

---

### E: Se a = 5; b = 3; c = 3

- Se (a < b + c) = TRUE; (b < a + c) = TRUE; (c < a + b) = TRUE
- Portanto: TRUE * TRUE * TRUE = TRUE
- Se (a = b) = FALSE; (b = c) = TRUE
- Portanto: FALSE * TRUE = FALSE
- Se (a = b) = FALSE; (b = c) = TRUE; (a = c) = FALSE
- Portanto: FALSE + TRUE + FALSE = TRUE
- Resultado: **"Tri�ngulo Is�sceles"**

| Passo  | Linha |  a  |  b  |  c  |                  Mensagem                   |
|--------|-------|-----|-----|-----|---------------------------------------------|
| In�cio |   -   |  0  |  0  |  0  | ""                                          |
| 1      |   7   |  5  |  0  |  0  | ""                                          |
| 2      |   9   |  5  |  3  |  0  | ""                                          |
| 3      |  11   |  5  |  3  |  3  | ""                                          |
| 4      |  17   |  5  |  3  |  3  | "Tri�ngulo Is�sceles"                       |

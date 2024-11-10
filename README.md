# Activitat 3 Tema 2 - Grup 2
## Integrants del grup 2:
- Alvaro Cobo
- Manel Arbiol
- Pol García
- Unai Calvet
- Ivan Garrido

# Rúbrica Avaluació grup 1
## Pseudocodi
| Criteri | 2 | 1 | 0 | Puntuació |
| ------ | ------ | ------ | ------ |-----------|
| Robust | El programa funciona al 100% i no hi ha errors  | El programa NO funciona al 100%. Hi ha errors  | El programa NO funciona (hi ha errors estructurals) | 0         |
| Correcte | La implementació de la solució és correcta al 100% | La implementació de la solució NO és correcta al 100% (no cobreix alguns casos)  | La implementació és mínima | 1         |
| Sintaxi |  La notació (variables, estructures,...) és correcta al 100%. Els noms són prou autodescriptius | La notació (variables, estructures,...) NO és correcta al 100%. Els noms no són prou autodescriptius en tots els casos | No se segueix la notació vista a classe | 2         |
| Comentaris | El pseudocodi conté la PRE i POST i els comentaris necessaris | Falta algun element (PRE, POST, comentaris necessaris) | No hi ha cap element (PRE, POST, comentaris necessaris) | 0         |

**Observacions:**
Truca a una funció o variable que no existeix (**vocalCouif**).

La funció **GetVocals** és truca a si mateixa, a més de tenir la funció Spell repetida a dins, sense cap sentit. A la
funció GetVocals vam haver d'afegir una condició que, si vocalCounter és major o igual a 2, assigni _true_ a **success**,
per finalment retornar aquesta variable.

**Puntuació total: 3/8**

## Flowchart
| Criteri | 2 | 1 | 0 | Puntuació |
| ------ | ------ | ------ | ------ |-----------|
| Robust | El programa funciona al 100% i no hi ha errors  | El programa NO funciona al 100%. Hi ha errors  | El programa NO funciona (hi ha errors estructurals) | 1         |
| Correcte | La implementació de la solució és correcta al 100% | La implementació de la solució NO és correcta al 100% (no cobreix alguns casos)  | La implementació és mínima | 2         |
| Sintaxi |  La notació (variables, símbols d'estructures,...) és correcta al 100%. Els noms són prou autodescriptius | La notació (variables, símbols d'estructures,...) NO és correcta al 100%. Els noms no són prou autodescriptius en tots els casos | No se segueix la notació vista a classe | 1         |
| Comentaris | El diagrama conté la PRE i POST i els comentaris necessaris (mitjançant anotacions) | Falta algun element (PRE, POST, comentaris necessaris) | No hi ha cap element (PRE, POST, comentaris necessaris) | 0         |

**Observacions:**
S'han oblidat de posar algunes línies a la funció **Spell**.

Algunes variables con _Name_ o _VocalCounter_ no segueixen la notació estàndard.

Hi ha condiciones poc clares com la de la funció _GetVocals_

**Puntuació total: 4/8**

# Rúbrica Avaluació grup 3
## Implementació en C#
| Criteri | 2 | 1 | 0 | Puntuació |
| ------ | ------ | ------ | ------ |-----------|
| Robust | El programa funciona al 100% i no hi ha errors (ni en compilació ni en execució)  | El programa NO funciona al 100%. Hi ha errors (en compilació o en execució)  | El programa NO funciona (hi ha errors estructurals) | 2         |
| Correcte | La implementació de la solució és correcta al 100% | La implementació de la solució NO és correcta al 100% (no cobreix alguns casos)  | La implementació és mínima | 1         |
| Sintaxi |  La notació (variables, estructures,...) és correcta al 100%, seguint les best practices de la comunitat. Els noms són prou autodescriptius | La notació (variables, estructures,...) NO és correcta al 100% (no segueix les best practices en tots els casos). Els noms no són prou autodescriptius en tots els casos | No se segueix la notació vista a classe | 1         |
| Comentaris | El pseudocodi conté la PRE i POST i els comentaris necessaris | Falta algun element (PRE, POST, comentaris necessaris) | No hi ha cap element (PRE, POST, comentaris necessaris) | 0         |

**Observacions:**
El programa funciona correctament, però només si no introdueixes un nom amb més de dues vocals. Si per exemple introdueixes
un nom amb 3, el programa dona error.

El nom de la funció _vocales_ no està escrites en UpperCamelCase.

**Puntuació total: 4/8**

## Testing
```c#
using ACThreeGroupTwo;
namespace TestACThreeGroupTwo {
    [TestClass]
    public class UtilsTest {

        [TestMethod]
        public void TestThreeVowels() {
            // Arrange
            string name = "juanjo";
            bool twoOrMoreVowels;
            // Act
            twoOrMoreVowels = Utils.GetVocals(name);
            // Assert
            Assert.IsTrue(twoOrMoreVowels);
        }
        [TestMethod]
        public void TestOneVowels() {
            // Arrange
            string name = "thor";
            bool twoOrMoreVowels;
            // Act
            twoOrMoreVowels = Utils.GetVocals(name);
            // Assert
            Assert.IsFalse(twoOrMoreVowels);
        }
        [TestMethod]
        public void TestTwoVowels() {
            // Arrange
            string name = "eric";
            bool twoOrMoreVowels;
            // Act
            twoOrMoreVowels = Utils.GetVocals(name);
            // Assert
            Assert.IsTrue(twoOrMoreVowels); //Gives error
        }
    }
}
```

**Observacions:**
Si introdueixes un name amb més de 2 vocals dona error.

Link al repositori avaluat: [link](https://github.com/SergiAlbalat/T2.Ac3-Equip1)
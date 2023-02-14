## Exercice 1
- Le but de l'exerice est de réaliser les tests de la méthode ***GetGrade*** de la classe ***GradingCalculator***

```
public class GradingCalculator {
    public int Score{get;set;}
    public int AttendancePercentage{get;set;}
    
    public char GetGrade() {
        if(Score > 90 && AttendancePercentage > 70) return 'A';
        else if(Score > 80 && AttendancePercentage > 60) return  'B';
        else if (Score > 60 && AttendancePercentage > 60) return  'C';
        else return 'F';
    }
}
```
**Les scénarios de tests** :

- Score : 95%, Présence : 90 => Note: A
- Score : 85%, Présence : 90 => Note: B
- Score : 65%, Présence : 90 => Note: C
- Score : 95%, Présence : 65 => Note: B
- Score : 95%, Présence : 55 => Note: F
- Score : 65%, Présence : 55 => Note: F
- Score : 50%, Présence : 90 => Note: F
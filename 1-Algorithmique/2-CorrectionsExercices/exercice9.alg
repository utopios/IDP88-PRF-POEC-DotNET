<?xml version="1.0" encoding="UTF-8"?>
<Algo>
    <description courant="AFFICHER &quot; €.&quot;" texte=""/>
    <extension extnom="inactif"/>
    <fonction fctetat="inactif" fctcode=""/>
    <F2 F2lignes="" F2etat="inactif" F2defaut="" F2para=""/>
    <repere repetat="inactif" repcode="-10#10#-10#10#2#2"/>
    <param totalBoucles="5000000" epaisseurLigne="2" epaisseurPoint="2" totalAffichages="1000" maxBoucle="500000" arrondiAuto="vrai" nbDecimales="8"/>
    <item code="200#declarationfonctions" algoitem="FONCTIONS_UTILISEES"/>
    <item code="100#declarationsvariables" algoitem="VARIABLES">
        <item code="1#NOMBRE#c" algoitem="c EST_DU_TYPE NOMBRE"/>
        <item code="1#NOMBRE#t" algoitem="t EST_DU_TYPE NOMBRE"/>
        <item code="1#NOMBRE#n" algoitem="n EST_DU_TYPE NOMBRE"/>
        <item code="1#NOMBRE#Cn" algoitem="Cn EST_DU_TYPE NOMBRE"/>
    </item>
    <item code="101#debutalgo" algoitem="DEBUT_ALGORITHME">
        <item code="4#Veuillez saisir le capital initial : #0" algoitem="AFFICHER &quot;Veuillez saisir le capital initial : &quot;"/>
        <item code="2#c#pasliste" algoitem="LIRE c"/>
        <item code="4#Veuillez saisir le taux#0" algoitem="AFFICHER &quot;Veuillez saisir le taux&quot;"/>
        <item code="2#t#pasliste" algoitem="LIRE t"/>
        <item code="4#Veuillez saisir le nombre d'années #0" algoitem="AFFICHER &quot;Veuillez saisir le nombre d'années &quot;"/>
        <item code="2#n#pasliste" algoitem="LIRE n"/>
        <item code="5#Cn#round(c*pow(1+(t/100),n))#pasliste" algoitem="Cn PREND_LA_VALEUR round(c*pow(1+(t/100),n))"/>
        <item code="4#Le montant total d'une epargne de#0" algoitem="AFFICHER &quot;Le montant total d'une epargne de&quot;"/>
        <item code="3#c#0#pasliste" algoitem="AFFICHER c"/>
        <item code="4#€ placé à un taux de#0" algoitem="AFFICHER &quot;€ placé à un taux de&quot;"/>
        <item code="3#t#0#pasliste" algoitem="AFFICHER t"/>
        <item code="4#% durant#0" algoitem="AFFICHER &quot;% durant&quot;"/>
        <item code="3#n#0#pasliste" algoitem="AFFICHER n"/>
        <item code="4# années s'éléve à#0" algoitem="AFFICHER &quot; années s'éléve à&quot;"/>
        <item code="3#Cn#0#pasliste" algoitem="AFFICHER Cn"/>
        <item code="4#Le montant des intérêts s'éléve à #0" algoitem="AFFICHER &quot;Le montant des intérêts s'éléve à &quot;"/>
        <item code="20#Cn-c#0" algoitem="AFFICHERCALCUL Cn-c"/>
        <item code="4# €.#0" algoitem="AFFICHER &quot; €.&quot;"/>
    </item>
    <item code="102#finalgo" algoitem="FIN_ALGORITHME"/>
</Algo>

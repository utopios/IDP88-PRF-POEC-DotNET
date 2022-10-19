<?xml version="1.0" encoding="UTF-8"?>
<Algo>
    <description courant="AFFICHER B" texte=""/>
    <extension extnom="inactif"/>
    <fonction fctetat="inactif" fctcode=""/>
    <F2 F2lignes="" F2para="" F2defaut="" F2etat="inactif"/>
    <repere repcode="-10#10#-10#10#2#2" repetat="inactif"/>
    <param totalAffichages="1000" epaisseurPoint="2" epaisseurLigne="2" arrondiAuto="vrai" maxBoucle="500000" totalBoucles="5000000" nbDecimales="8"/>
    <item algoitem="FONCTIONS_UTILISEES" code="200#declarationfonctions"/>
    <item algoitem="VARIABLES" code="100#declarationsvariables">
        <item algoitem="A EST_DU_TYPE NOMBRE" code="1#NOMBRE#A"/>
        <item algoitem="B EST_DU_TYPE NOMBRE" code="1#NOMBRE#B"/>
    </item>
    <item algoitem="DEBUT_ALGORITHME" code="101#debutalgo">
        <item algoitem="AFFICHER &quot;entrer un nombre :&quot;" code="4#entrer un nombre :#1"/>
        <item algoitem="LIRE A" code="2#A#pasliste"/>
        <item algoitem="B PREND_LA_VALEUR 2*A" code="5#B#2*A#pasliste"/>
        <item algoitem="AFFICHER &quot;le double de &quot;" code="4#le double de #1"/>
        <item algoitem="AFFICHER A" code="3#A#1#pasliste"/>
        <item algoitem="AFFICHER &quot;est :&quot;" code="4#est :#1"/>
        <item algoitem="AFFICHER B" code="3#B#1#pasliste"/>
    </item>
    <item algoitem="FIN_ALGORITHME" code="102#finalgo"/>
</Algo>

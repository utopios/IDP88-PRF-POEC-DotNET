<?xml version="1.0" encoding="UTF-8"?>
<Algo>
    <description courant="AFFICHER Annee" texte=""/>
    <extension extnom="inactif"/>
    <fonction fctetat="inactif" fctcode=""/>
    <F2 F2etat="inactif" F2defaut="" F2lignes="" F2para=""/>
    <repere repetat="inactif" repcode="-10#10#-10#10#2#2"/>
    <param totalBoucles="5000000" maxBoucle="500000" arrondiAuto="vrai" nbDecimales="8" totalAffichages="1000" epaisseurPoint="2" epaisseurLigne="2"/>
    <item algoitem="FONCTIONS_UTILISEES" code="200#declarationfonctions"/>
    <item algoitem="VARIABLES" code="100#declarationsvariables">
        <item algoitem="nbAnnee EST_DU_TYPE NOMBRE" code="1#NOMBRE#nbAnnee"/>
        <item algoitem="Habitant EST_DU_TYPE NOMBRE" code="1#NOMBRE#Habitant"/>
        <item algoitem="Annee EST_DU_TYPE NOMBRE" code="1#NOMBRE#Annee"/>
        <item algoitem="taux EST_DU_TYPE NOMBRE" code="1#NOMBRE#taux"/>
    </item>
    <item algoitem="DEBUT_ALGORITHME" code="101#debutalgo">
        <item algoitem="nbAnnee PREND_LA_VALEUR 0" code="5#nbAnnee#0#pasliste"/>
        <item algoitem="Habitant PREND_LA_VALEUR 96809" code="5#Habitant#96809#pasliste"/>
        <item algoitem="taux PREND_LA_VALEUR 0.89" code="5#taux#0.89#pasliste"/>
        <item algoitem="Annee PREND_LA_VALEUR 2015" code="5#Annee#2015#pasliste"/>
        <item algoitem="TANT_QUE (Habitant &lt; 120000) FAIRE" code="15#Habitant &lt; 120000">
            <item algoitem="DEBUT_TANT_QUE" code="16#debuttantque"/>
            <item algoitem="Habitant PREND_LA_VALEUR Habitant + (taux * Habitant/100)" code="5#Habitant#Habitant + (taux * Habitant/100)#pasliste"/>
            <item algoitem="nbAnnee PREND_LA_VALEUR nbAnnee + 1" code="5#nbAnnee#nbAnnee + 1#pasliste"/>
            <item algoitem="Annee PREND_LA_VALEUR Annee + 1" code="5#Annee#Annee + 1#pasliste"/>
            <item algoitem="FIN_TANT_QUE" code="17#fintantque"/>
        </item>
        <item algoitem="Habitant PREND_LA_VALEUR round(Habitant)" code="5#Habitant#round(Habitant)#pasliste"/>
        <item algoitem="AFFICHER &quot;Il faudra &quot;" code="4#Il faudra #0"/>
        <item algoitem="AFFICHER nbAnnee" code="3#nbAnnee#0#pasliste"/>
        <item algoitem="AFFICHER &quot; année(s) pour atteindre la population de &quot;" code="4# année(s) pour atteindre la population de #0"/>
        <item algoitem="AFFICHER Habitant" code="3#Habitant#0#pasliste"/>
        <item algoitem="AFFICHER &quot; habitants. Nous serons en &quot;" code="4# habitants. Nous serons en #0"/>
        <item algoitem="AFFICHER Annee" code="3#Annee#0#pasliste"/>
    </item>
    <item algoitem="FIN_ALGORITHME" code="102#finalgo"/>
</Algo>

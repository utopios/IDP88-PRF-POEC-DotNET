<?xml version="1.0" encoding="UTF-8"?>
<Algo>
    <description courant="AFFICHER noteMax" texte=""/>
    <extension extnom="inactif"/>
    <fonction fctcode="" fctetat="inactif"/>
    <F2 F2para="" F2etat="inactif" F2defaut="" F2lignes=""/>
    <repere repcode="-10#10#-10#10#2#2" repetat="inactif"/>
    <param arrondiAuto="vrai" maxBoucle="500000" totalAffichages="1000" nbDecimales="8" epaisseurPoint="2" totalBoucles="5000000" epaisseurLigne="2"/>
    <item algoitem="FONCTIONS_UTILISEES" code="200#declarationfonctions"/>
    <item algoitem="VARIABLES" code="100#declarationsvariables">
        <item algoitem="Tmp EST_DU_TYPE NOMBRE" code="1#NOMBRE#Tmp"/>
        <item algoitem="i EST_DU_TYPE NOMBRE" code="1#NOMBRE#i"/>
        <item algoitem="noteMax EST_DU_TYPE NOMBRE" code="1#NOMBRE#noteMax"/>
    </item>
    <item algoitem="DEBUT_ALGORITHME" code="101#debutalgo">
        <item algoitem="noteMax PREND_LA_VALEUR 0" code="5#noteMax#0#pasliste"/>
        <item algoitem="POUR i ALLANT_DE 1 A 6" code="12#i#1#6">
            <item algoitem="DEBUT_POUR" code="13#debutpour"/>
            <item algoitem="AFFICHER &quot;Veuillez saisir le nombre n°&quot;" code="4#Veuillez saisir le nombre n°#0"/>
            <item algoitem="AFFICHER i" code="3#i#1#pasliste"/>
            <item algoitem="LIRE Tmp" code="2#Tmp#pasliste"/>
            <item algoitem="SI (Tmp > noteMax) ALORS" code="6#Tmp > noteMax">
                <item algoitem="DEBUT_SI" code="7#debutsi"/>
                <item algoitem="noteMax PREND_LA_VALEUR Tmp" code="5#noteMax#Tmp#pasliste"/>
                <item algoitem="FIN_SI" code="8#finsi"/>
            </item>
            <item algoitem="FIN_POUR" code="14#finpour"/>
        </item>
        <item algoitem="AFFICHER &quot;Le plus grand nombre est &quot;" code="4#Le plus grand nombre est #0"/>
        <item algoitem="AFFICHER noteMax" code="3#noteMax#1#pasliste"/>
    </item>
    <item algoitem="FIN_ALGORITHME" code="102#finalgo"/>
</Algo>

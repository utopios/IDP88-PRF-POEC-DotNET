<?xml version="1.0" encoding="UTF-8"?>
<Algo>
    <description courant="AFFICHER NomComplet" texte=""/>
    <extension extnom="inactif"/>
    <fonction fctetat="inactif" fctcode=""/>
    <F2 F2lignes="" F2para="" F2defaut="" F2etat="inactif"/>
    <repere repcode="-10#10#-10#10#2#2" repetat="inactif"/>
    <param totalAffichages="1000" epaisseurPoint="2" epaisseurLigne="2" arrondiAuto="vrai" maxBoucle="500000" totalBoucles="5000000" nbDecimales="8"/>
    <item algoitem="FONCTIONS_UTILISEES" code="200#declarationfonctions"/>
    <item algoitem="VARIABLES" code="100#declarationsvariables">
        <item algoitem="Nom EST_DU_TYPE CHAINE" code="1#CHAINE#Nom"/>
        <item algoitem="Prenom EST_DU_TYPE CHAINE" code="1#CHAINE#Prenom"/>
        <item algoitem="NomComplet EST_DU_TYPE CHAINE" code="1#CHAINE#NomComplet"/>
    </item>
    <item algoitem="DEBUT_ALGORITHME" code="101#debutalgo">
        <item algoitem="AFFICHER &quot;Taper votre prenom&quot;" code="4#Taper votre prenom#1"/>
        <item algoitem="LIRE Prenom" code="2#Prenom#pasliste"/>
        <item algoitem="AFFICHER &quot;Taper votre nom&quot;" code="4#Taper votre nom#1"/>
        <item algoitem="LIRE Nom" code="2#Nom#pasliste"/>
        <item algoitem="NomComplet PREND_LA_VALEUR Nom + ' ' + Prenom" code="5#NomComplet#Nom + ' ' + Prenom#pasliste"/>
        <item algoitem="AFFICHER &quot;Votre nom complet est &quot;" code="4#Votre nom complet est #1"/>
        <item algoitem="AFFICHER NomComplet" code="3#NomComplet#1#pasliste"/>
    </item>
    <item algoitem="FIN_ALGORITHME" code="102#finalgo"/>
</Algo>

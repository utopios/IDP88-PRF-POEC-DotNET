<?xml version="1.0" encoding="UTF-8"?>
<Algo>
    <description courant="AFFICHER &quot;Saisie correcte !&quot;" texte=""/>
    <extension extnom="inactif"/>
    <fonction fctcode="" fctetat="inactif"/>
    <F2 F2para="" F2etat="inactif" F2defaut="" F2lignes=""/>
    <repere repcode="-10#10#-10#10#2#2" repetat="inactif"/>
    <param arrondiAuto="vrai" maxBoucle="500000" totalAffichages="1000" nbDecimales="8" epaisseurPoint="2" totalBoucles="5000000" epaisseurLigne="2"/>
    <item algoitem="FONCTIONS_UTILISEES" code="200#declarationfonctions"/>
    <item algoitem="VARIABLES" code="100#declarationsvariables">
        <item algoitem="userNum EST_DU_TYPE NOMBRE" code="1#NOMBRE#userNum"/>
    </item>
    <item algoitem="DEBUT_ALGORITHME" code="101#debutalgo">
        <item algoitem="AFFICHER &quot;Veuillez saisir un nombre :&quot;" code="4#Veuillez saisir un nombre :#0"/>
        <item algoitem="LIRE userNum" code="2#userNum#pasliste"/>
        <item algoitem="TANT_QUE (userNum &lt;1 OU userNum >3) FAIRE" code="15#userNum &lt;1 OU userNum >3">
            <item algoitem="DEBUT_TANT_QUE" code="16#debuttantque"/>
            <item algoitem="AFFICHER &quot;Saisie Incorrecte, veuillez  réessayer ...&quot;" code="4#Saisie Incorrecte, veuillez  réessayer ...#0"/>
            <item algoitem="LIRE userNum" code="2#userNum#pasliste"/>
            <item algoitem="FIN_TANT_QUE" code="17#fintantque"/>
        </item>
        <item algoitem="AFFICHER &quot;Saisie correcte !&quot;" code="4#Saisie correcte !#0"/>
    </item>
    <item algoitem="FIN_ALGORITHME" code="102#finalgo"/>
</Algo>

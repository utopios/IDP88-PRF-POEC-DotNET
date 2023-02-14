<?xml version="1.0" encoding="UTF-8"?>
<Algo>
    <description courant="AFFICHER &quot; €.&quot;" texte=""/>
    <extension extnom="inactif"/>
    <fonction fctcode="" fctetat="inactif"/>
    <F2 F2para="" F2etat="inactif" F2defaut="" F2lignes=""/>
    <repere repcode="-10#10#-10#10#2#2" repetat="inactif"/>
    <param arrondiAuto="vrai" maxBoucle="500000" totalAffichages="1000" nbDecimales="8" epaisseurPoint="2" totalBoucles="5000000" epaisseurLigne="2"/>
    <item algoitem="FONCTIONS_UTILISEES" code="200#declarationfonctions"/>
    <item algoitem="VARIABLES" code="100#declarationsvariables">
        <item algoitem="Ci EST_DU_TYPE NOMBRE" code="1#NOMBRE#Ci"/>
        <item algoitem="Taux EST_DU_TYPE NOMBRE" code="1#NOMBRE#Taux"/>
        <item algoitem="Annee EST_DU_TYPE NOMBRE" code="1#NOMBRE#Annee"/>
        <item algoitem="Cf EST_DU_TYPE NOMBRE" code="1#NOMBRE#Cf"/>
    </item>
    <item algoitem="DEBUT_ALGORITHME" code="101#debutalgo">
        <item algoitem="AFFICHER &quot;Veuillez saisir le capital initial&quot;" code="4#Veuillez saisir le capital initial#0"/>
        <item algoitem="LIRE Ci" code="2#Ci#pasliste"/>
        <item algoitem="AFFICHER &quot;Veuillez saisir le taux d'intérêt&quot;" code="4#Veuillez saisir le taux d'intérêt#0"/>
        <item algoitem="LIRE Taux" code="2#Taux#pasliste"/>
        <item algoitem="Taux PREND_LA_VALEUR Taux/100" code="5#Taux#Taux/100#pasliste"/>
        <item algoitem="TANT_QUE (Cf &lt; 2 * Ci) FAIRE" code="15#Cf &lt; 2 * Ci">
            <item algoitem="DEBUT_TANT_QUE" code="16#debuttantque"/>
            <item algoitem="Annee PREND_LA_VALEUR Annee + 1" code="5#Annee#Annee + 1#pasliste"/>
            <item algoitem="Cf PREND_LA_VALEUR round(Ci * pow(1+Taux,Annee))" code="5#Cf#round(Ci * pow(1+Taux,Annee))#pasliste"/>
            <item algoitem="FIN_TANT_QUE" code="17#fintantque"/>
        </item>
        <item algoitem="AFFICHER &quot;Il faudra &quot;" code="4#Il faudra #0"/>
        <item algoitem="AFFICHER Annee" code="3#Annee#0#pasliste"/>
        <item algoitem="AFFICHER &quot; année(s) pour doubler le capital. Le montant sera alors de &quot;" code="4# année(s) pour doubler le capital. Le montant sera alors de #0"/>
        <item algoitem="AFFICHER Cf" code="3#Cf#0#pasliste"/>
        <item algoitem="AFFICHER &quot; €.&quot;" code="4# €.#0"/>
    </item>
    <item algoitem="FIN_ALGORITHME" code="102#finalgo"/>
</Algo>

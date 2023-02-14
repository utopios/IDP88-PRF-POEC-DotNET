<?xml version="1.0" encoding="UTF-8"?>
<Algo>
    <description courant="FIN_SINON" texte=""/>
    <extension extnom="inactif"/>
    <fonction fctetat="inactif" fctcode=""/>
    <F2 F2defaut="" F2para="" F2etat="inactif" F2lignes=""/>
    <repere repcode="-10#10#-10#10#2#2" repetat="inactif"/>
    <param epaisseurLigne="2" totalAffichages="1000" totalBoucles="5000000" arrondiAuto="vrai" maxBoucle="500000" epaisseurPoint="2" nbDecimales="8"/>
    <item code="200#declarationfonctions" algoitem="FONCTIONS_UTILISEES"/>
    <item code="100#declarationsvariables" algoitem="VARIABLES">
        <item code="1#NOMBRE#X" algoitem="X EST_DU_TYPE NOMBRE"/>
    </item>
    <item code="101#debutalgo" algoitem="DEBUT_ALGORITHME">
        <item code="4#Entre un réel : #0" algoitem="AFFICHER &quot;Entre un réel : &quot;"/>
        <item code="2#X#pasliste" algoitem="LIRE X"/>
        <item code="6#X&lt;0" algoitem="SI (X&lt;0) ALORS">
            <item code="7#debutsi" algoitem="DEBUT_SI"/>
            <item code="4#LA valeur absolue de #0" algoitem="AFFICHER &quot;LA valeur absolue de &quot;"/>
            <item code="3#X#0#pasliste" algoitem="AFFICHER X"/>
            <item code="4# est #0" algoitem="AFFICHER &quot; est &quot;"/>
            <item code="5#X#-X#pasliste" algoitem="X PREND_LA_VALEUR -X"/>
            <item code="3#X#1#pasliste" algoitem="AFFICHER X"/>
            <item code="8#finsi" algoitem="FIN_SI"/>
            <item code="9#sinon" algoitem="SINON">
                <item code="10#debutsinon" algoitem="DEBUT_SINON"/>
                <item code="4#LA valeur absolue de #0" algoitem="AFFICHER &quot;LA valeur absolue de &quot;"/>
                <item code="3#X#0#pasliste" algoitem="AFFICHER X"/>
                <item code="4# est #0" algoitem="AFFICHER &quot; est &quot;"/>
                <item code="3#X#0#pasliste" algoitem="AFFICHER X"/>
                <item code="11#finsinon" algoitem="FIN_SINON"/>
            </item>
        </item>
    </item>
    <item code="102#finalgo" algoitem="FIN_ALGORITHME"/>
</Algo>

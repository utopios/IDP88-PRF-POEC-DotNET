<?xml version="1.0" encoding="UTF-8"?>
<Algo>
    <description courant="FIN_SINON" texte=""/>
    <extension extnom="inactif"/>
    <fonction fctetat="inactif" fctcode=""/>
    <F2 F2lignes="" F2etat="inactif" F2defaut="" F2para=""/>
    <repere repetat="inactif" repcode="-10#10#-10#10#2#2"/>
    <param totalBoucles="5000000" epaisseurLigne="2" epaisseurPoint="2" totalAffichages="1000" maxBoucle="500000" arrondiAuto="vrai" nbDecimales="8"/>
    <item code="200#declarationfonctions" algoitem="FONCTIONS_UTILISEES"/>
    <item code="100#declarationsvariables" algoitem="VARIABLES">
        <item code="1#NOMBRE#X" algoitem="X EST_DU_TYPE NOMBRE"/>
    </item>
    <item code="101#debutalgo" algoitem="DEBUT_ALGORITHME">
        <item code="4#Veuillez saisir un nombre :#0" algoitem="AFFICHER &quot;Veuillez saisir un nombre :&quot;"/>
        <item code="2#X#pasliste" algoitem="LIRE X"/>
        <item code="6#X % 3 == 0" algoitem="SI (X % 3 == 0) ALORS">
            <item code="7#debutsi" algoitem="DEBUT_SI"/>
            <item code="4#Le nombre #0" algoitem="AFFICHER &quot;Le nombre &quot;"/>
            <item code="3#X#0#pasliste" algoitem="AFFICHER X"/>
            <item code="4# est divisble par 3#0" algoitem="AFFICHER &quot; est divisble par 3&quot;"/>
            <item code="8#finsi" algoitem="FIN_SI"/>
            <item code="9#sinon" algoitem="SINON">
                <item code="10#debutsinon" algoitem="DEBUT_SINON"/>
                <item code="4#Le nombre #0" algoitem="AFFICHER &quot;Le nombre &quot;"/>
                <item code="3#X#0#pasliste" algoitem="AFFICHER X"/>
                <item code="4# n'est pas divisble par 3#0" algoitem="AFFICHER &quot; n'est pas divisble par 3&quot;"/>
                <item code="11#finsinon" algoitem="FIN_SINON"/>
            </item>
        </item>
    </item>
    <item code="102#finalgo" algoitem="FIN_ALGORITHME"/>
</Algo>

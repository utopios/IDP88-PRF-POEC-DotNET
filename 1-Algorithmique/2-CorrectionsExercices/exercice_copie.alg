<?xml version="1.0" encoding="UTF-8"?>
<Algo>
    <description courant="AFFICHER &quot; Euros&quot;" texte=""/>
    <extension extnom="inactif"/>
    <fonction fctetat="inactif" fctcode=""/>
    <F2 F2lignes="" F2etat="inactif" F2defaut="" F2para=""/>
    <repere repetat="inactif" repcode="-10#10#-10#10#2#2"/>
    <param totalBoucles="5000000" epaisseurLigne="2" epaisseurPoint="2" totalAffichages="1000" maxBoucle="500000" arrondiAuto="vrai" nbDecimales="8"/>
    <item code="200#declarationfonctions" algoitem="FONCTIONS_UTILISEES"/>
    <item code="100#declarationsvariables" algoitem="VARIABLES">
        <item code="1#NOMBRE#Montant" algoitem="Montant EST_DU_TYPE NOMBRE"/>
        <item code="1#NOMBRE#NbCopies" algoitem="NbCopies EST_DU_TYPE NOMBRE"/>
    </item>
    <item code="101#debutalgo" algoitem="DEBUT_ALGORITHME">
        <item code="4#Veuillez saisir le nombre de copies : #0" algoitem="AFFICHER &quot;Veuillez saisir le nombre de copies : &quot;"/>
        <item code="2#NbCopies#pasliste" algoitem="LIRE NbCopies"/>
        <item code="6#NbCopies &lt; 10" algoitem="SI (NbCopies &lt; 10) ALORS">
            <item code="7#debutsi" algoitem="DEBUT_SI"/>
            <item code="5#Montant#NbCopies * 0.5#pasliste" algoitem="Montant PREND_LA_VALEUR NbCopies * 0.5"/>
            <item code="8#finsi" algoitem="FIN_SI"/>
            <item code="9#sinon" algoitem="SINON">
                <item code="10#debutsinon" algoitem="DEBUT_SINON"/>
                <item code="6#NbCopies >=10 ET NbCopies &lt;= 20" algoitem="SI (NbCopies >=10 ET NbCopies &lt;= 20) ALORS">
                    <item code="7#debutsi" algoitem="DEBUT_SI"/>
                    <item code="5#Montant#NbCopies * 0.4#pasliste" algoitem="Montant PREND_LA_VALEUR NbCopies * 0.4"/>
                    <item code="8#finsi" algoitem="FIN_SI"/>
                    <item code="9#sinon" algoitem="SINON">
                        <item code="10#debutsinon" algoitem="DEBUT_SINON"/>
                        <item code="5#Montant#NbCopies * 0.3#pasliste" algoitem="Montant PREND_LA_VALEUR NbCopies * 0.3"/>
                        <item code="11#finsinon" algoitem="FIN_SINON"/>
                    </item>
                </item>
                <item code="11#finsinon" algoitem="FIN_SINON"/>
            </item>
        </item>
        <item code="4#Le montant total est de #0" algoitem="AFFICHER &quot;Le montant total est de &quot;"/>
        <item code="3#Montant#0#pasliste" algoitem="AFFICHER Montant"/>
        <item code="4# Euros#0" algoitem="AFFICHER &quot; Euros&quot;"/>
    </item>
    <item code="102#finalgo" algoitem="FIN_ALGORITHME"/>
</Algo>

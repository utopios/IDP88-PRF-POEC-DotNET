<?xml version="1.0" encoding="UTF-8"?>
<Algo>
    <description courant="AFFICHER Response" texte=""/>
    <extension extnom="inactif"/>
    <fonction fctetat="inactif" fctcode=""/>
    <F2 F2lignes="" F2etat="inactif" F2defaut="" F2para=""/>
    <repere repetat="inactif" repcode="-10#10#-10#10#2#2"/>
    <param totalBoucles="5000000" epaisseurLigne="2" epaisseurPoint="2" totalAffichages="1000" maxBoucle="500000" arrondiAuto="vrai" nbDecimales="8"/>
    <item code="200#declarationfonctions" algoitem="FONCTIONS_UTILISEES"/>
    <item code="100#declarationsvariables" algoitem="VARIABLES">
        <item code="1#NOMBRE#AB" algoitem="AB EST_DU_TYPE NOMBRE"/>
        <item code="1#NOMBRE#BC" algoitem="BC EST_DU_TYPE NOMBRE"/>
        <item code="1#NOMBRE#CA" algoitem="CA EST_DU_TYPE NOMBRE"/>
        <item code="1#CHAINE#Response" algoitem="Response EST_DU_TYPE CHAINE"/>
    </item>
    <item code="101#debutalgo" algoitem="DEBUT_ALGORITHME">
        <item code="4#Veuillez saisir la longeur du segment AB : #0" algoitem="AFFICHER &quot;Veuillez saisir la longeur du segment AB : &quot;"/>
        <item code="2#AB#pasliste" algoitem="LIRE AB"/>
        <item code="4#Veuillez saisir la longeur du segment BC : #0" algoitem="AFFICHER &quot;Veuillez saisir la longeur du segment BC : &quot;"/>
        <item code="2#BC#pasliste" algoitem="LIRE BC"/>
        <item code="4#Veuillez saisir la longeur du segment CA : #0" algoitem="AFFICHER &quot;Veuillez saisir la longeur du segment CA : &quot;"/>
        <item code="2#CA#pasliste" algoitem="LIRE CA"/>
        <item code="6#AB == BC" algoitem="SI (AB == BC) ALORS">
            <item code="7#debutsi" algoitem="DEBUT_SI"/>
            <item code="6#BC == CA" algoitem="SI (BC == CA) ALORS">
                <item code="7#debutsi" algoitem="DEBUT_SI"/>
                <item code="5#Response#&quot;Le triangle est équilatéral&quot;#pasliste" algoitem="Response PREND_LA_VALEUR &quot;Le triangle est équilatéral&quot;"/>
                <item code="8#finsi" algoitem="FIN_SI"/>
                <item code="9#sinon" algoitem="SINON">
                    <item code="10#debutsinon" algoitem="DEBUT_SINON"/>
                    <item code="5#Response#&quot;Le triangle est isolcèle en B.&quot;#pasliste" algoitem="Response PREND_LA_VALEUR &quot;Le triangle est isolcèle en B.&quot;"/>
                    <item code="11#finsinon" algoitem="FIN_SINON"/>
                </item>
            </item>
            <item code="8#finsi" algoitem="FIN_SI"/>
            <item code="9#sinon" algoitem="SINON">
                <item code="10#debutsinon" algoitem="DEBUT_SINON"/>
                <item code="6#BC == CA" algoitem="SI (BC == CA) ALORS">
                    <item code="7#debutsi" algoitem="DEBUT_SI"/>
                    <item code="5#Response#&quot;Le triangle est isocèle en C.&quot;#pasliste" algoitem="Response PREND_LA_VALEUR &quot;Le triangle est isocèle en C.&quot;"/>
                    <item code="8#finsi" algoitem="FIN_SI"/>
                    <item code="9#sinon" algoitem="SINON">
                        <item code="10#debutsinon" algoitem="DEBUT_SINON"/>
                        <item code="6#AB == CA" algoitem="SI (AB == CA) ALORS">
                            <item code="7#debutsi" algoitem="DEBUT_SI"/>
                            <item code="5#Response#&quot;Le triangle est isocèle en A.&quot;#pasliste" algoitem="Response PREND_LA_VALEUR &quot;Le triangle est isocèle en A.&quot;"/>
                            <item code="8#finsi" algoitem="FIN_SI"/>
                            <item code="9#sinon" algoitem="SINON">
                                <item code="10#debutsinon" algoitem="DEBUT_SINON"/>
                                <item code="5#Response#&quot;Le triangle n'est isocèle ni en A, ni en B, ni en C.&quot;#pasliste" algoitem="Response PREND_LA_VALEUR &quot;Le triangle n'est isocèle ni en A, ni en B, ni en C.&quot;"/>
                                <item code="11#finsinon" algoitem="FIN_SINON"/>
                            </item>
                        </item>
                        <item code="11#finsinon" algoitem="FIN_SINON"/>
                    </item>
                </item>
                <item code="11#finsinon" algoitem="FIN_SINON"/>
            </item>
        </item>
        <item code="3#Response#0#pasliste" algoitem="AFFICHER Response"/>
    </item>
    <item code="102#finalgo" algoitem="FIN_ALGORITHME"/>
</Algo>

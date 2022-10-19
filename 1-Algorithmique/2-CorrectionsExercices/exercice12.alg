<?xml version="1.0" encoding="UTF-8"?>
<Algo>
    <description courant="FIN_SINON" texte=""/>
    <extension extnom="inactif"/>
    <fonction fctcode="" fctetat="inactif"/>
    <F2 F2para="" F2etat="inactif" F2defaut="" F2lignes=""/>
    <repere repcode="-10#10#-10#10#2#2" repetat="inactif"/>
    <param arrondiAuto="vrai" maxBoucle="500000" totalAffichages="1000" nbDecimales="8" epaisseurPoint="2" totalBoucles="5000000" epaisseurLigne="2"/>
    <item algoitem="FONCTIONS_UTILISEES" code="200#declarationfonctions"/>
    <item algoitem="VARIABLES" code="100#declarationsvariables">
        <item algoitem="CENT EST_DU_TYPE NOMBRE" code="1#NOMBRE#CENT"/>
        <item algoitem="POIDS EST_DU_TYPE NOMBRE" code="1#NOMBRE#POIDS"/>
        <item algoitem="TAILLE EST_DU_TYPE NOMBRE" code="1#NOMBRE#TAILLE"/>
    </item>
    <item algoitem="DEBUT_ALGORITHME" code="101#debutalgo">
        <item algoitem="AFFICHER &quot;DONNER UNE TAILLE EN CM&quot;" code="4#DONNER UNE TAILLE EN CM#0"/>
        <item algoitem="LIRE CENT" code="2#CENT#pasliste"/>
        <item algoitem="AFFICHER &quot;DONNER UN POIDS EN KG&quot;" code="4#DONNER UN POIDS EN KG#0"/>
        <item algoitem="LIRE POIDS" code="2#POIDS#pasliste"/>
        <item algoitem="SI ((POIDS>=43 ET POIDS&lt;=47 ET CENT >=145 ET CENT&lt;172) OU (POIDS>=48 ET POIDS&lt;=53 ET CENT >=145 ET CENT&lt;169) OU (POIDS>=54 ET POIDS&lt;=59 ET CENT >=145 ET CENT&lt;166) OU (POIDS>=60 ET POIDS&lt;=65 ET CENT >=145 ET CENT&lt;163) ) ALORS" code="6#(POIDS>=43 ET POIDS&lt;=47 ET CENT >=145 ET CENT&lt;172) OU (POIDS>=48 ET POIDS&lt;=53 ET CENT >=145 ET CENT&lt;169) OU (POIDS>=54 ET POIDS&lt;=59 ET CENT >=145 ET CENT&lt;166) OU (POIDS>=60 ET POIDS&lt;=65 ET CENT >=145 ET CENT&lt;163) ">
            <item algoitem="DEBUT_SI" code="7#debutsi"/>
            <item algoitem="TAILLE PREND_LA_VALEUR 1" code="5#TAILLE#1#pasliste"/>
            <item algoitem="FIN_SI" code="8#finsi"/>
            <item algoitem="SINON" code="9#sinon">
                <item algoitem="DEBUT_SINON" code="10#debutsinon"/>
                <item algoitem="SI ((POIDS>=48 ET POIDS&lt;=53 ET CENT >=169 ET CENT&lt;183) OU (POIDS>=54 ET POIDS&lt;=59 ET CENT >=166 ET CENT&lt;178) OU (POIDS>=60 ET POIDS&lt;=65 ET CENT >=163 ET CENT&lt;175) OU (POIDS>=66 ET POIDS&lt;=71 ET CENT >=160 ET CENT&lt;172)) ALORS" code="6#(POIDS>=48 ET POIDS&lt;=53 ET CENT >=169 ET CENT&lt;183) OU (POIDS>=54 ET POIDS&lt;=59 ET CENT >=166 ET CENT&lt;178) OU (POIDS>=60 ET POIDS&lt;=65 ET CENT >=163 ET CENT&lt;175) OU (POIDS>=66 ET POIDS&lt;=71 ET CENT >=160 ET CENT&lt;172)">
                    <item algoitem="DEBUT_SI" code="7#debutsi"/>
                    <item algoitem="TAILLE PREND_LA_VALEUR 2" code="5#TAILLE#2#pasliste"/>
                    <item algoitem="FIN_SI" code="8#finsi"/>
                    <item algoitem="SINON" code="9#sinon">
                        <item algoitem="DEBUT_SINON" code="10#debutsinon"/>
                        <item algoitem="SI ((POIDS>=54 ET POIDS&lt;=59 ET CENT >=178 ET CENT&lt;=183) OU (POIDS>=60 ET POIDS&lt;=65 ET CENT >=175 ET CENT&lt;=183) OU (POIDS>=66 ET POIDS&lt;=71 ET CENT >=172 ET CENT&lt;=183) OU (POIDS>=72 ET POIDS&lt;=77 ET CENT >=163 ET CENT&lt;=183)) ALORS" code="6#(POIDS>=54 ET POIDS&lt;=59 ET CENT >=178 ET CENT&lt;=183) OU (POIDS>=60 ET POIDS&lt;=65 ET CENT >=175 ET CENT&lt;=183) OU (POIDS>=66 ET POIDS&lt;=71 ET CENT >=172 ET CENT&lt;=183) OU (POIDS>=72 ET POIDS&lt;=77 ET CENT >=163 ET CENT&lt;=183)">
                            <item algoitem="DEBUT_SI" code="7#debutsi"/>
                            <item algoitem="TAILLE PREND_LA_VALEUR 3" code="5#TAILLE#3#pasliste"/>
                            <item algoitem="FIN_SI" code="8#finsi"/>
                            <item algoitem="SINON" code="9#sinon">
                                <item algoitem="DEBUT_SINON" code="10#debutsinon"/>
                                <item algoitem="TAILLE PREND_LA_VALEUR 0" code="5#TAILLE#0#pasliste"/>
                                <item algoitem="FIN_SINON" code="11#finsinon"/>
                            </item>
                        </item>
                        <item algoitem="FIN_SINON" code="11#finsinon"/>
                    </item>
                </item>
                <item algoitem="FIN_SINON" code="11#finsinon"/>
            </item>
        </item>
        <item algoitem="SI (TAILLE > 0) ALORS" code="6#TAILLE > 0">
            <item algoitem="DEBUT_SI" code="7#debutsi"/>
            <item algoitem="AFFICHER &quot;Prenez la taille : &quot;" code="4#Prenez la taille : #0"/>
            <item algoitem="AFFICHER TAILLE" code="3#TAILLE#0#pasliste"/>
            <item algoitem="FIN_SI" code="8#finsi"/>
            <item algoitem="SINON" code="9#sinon">
                <item algoitem="DEBUT_SINON" code="10#debutsinon"/>
                <item algoitem="AFFICHER &quot;Aucune taille ne vous correspond&quot;" code="4#Aucune taille ne vous correspond#0"/>
                <item algoitem="FIN_SINON" code="11#finsinon"/>
            </item>
        </item>
    </item>
    <item algoitem="FIN_ALGORITHME" code="102#finalgo"/>
</Algo>

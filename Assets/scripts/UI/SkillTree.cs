using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class SkillTree : MonoBehaviour
{
    
    public static int SkillPoints = 0; //ep counter for amount of food consumed
    public static int TotalSpentSP = 0;

    public Move MvmSpeed;
    public static int Armor;

    public Button Cilium; //skill tree button
    public Button CellMembrane;
    public Button Flagella; 

    public static int Ciliumlvl = 0; //for tracking the amount of levels per skill
    public static int CellMembranelvl = 0;
    public static int Flagellalvl = 0;

    public Text CiliumText;
    public Text CellMembraneText;
    public Text FlagellaText;

    public static int CiliumReq = 1;
    public static int CellMembraneReq = 3;
    public static int FlagellaReq = 5;

    public Text skillNameTxt;
    public Text skillDescTxt;

    void Start()
    {
        skillNameTxt.enabled = false;
        skillDescTxt.enabled = false;
    }
    void Update() //yanderedev if else 10gb Problem still have: skillpoints sometimes get to negative and new skillpoints amount sometimes get ignored
    {
        if (SkillPoints == 0)
        {
            Cilium.interactable = false;
            CellMembrane.interactable = false;
            Flagella.interactable = false;
        } 
        else if (SkillPoints <= -1) {
            Cilium.interactable = false;
            CellMembrane.interactable = false;
            Flagella.interactable = false;
        } else {
            Cilium.interactable = true;
            CellMembrane.interactable = true;
            Flagella.interactable = true;
        }
        if ((Ciliumlvl >= 5) || (SkillPoints < CiliumReq)) {
            Cilium.interactable = false;
            Cilium.GetComponent<Image>().color = new Color (54, 69, 79);
        } else {
            Cilium.interactable = true;
        }
        if ((Flagellalvl >= 5) || (SkillPoints < FlagellaReq)){
            Flagella.interactable = false;
            Cilium.GetComponent<Image>().color = new Color (54, 69, 79);
        } else {
            Flagella.interactable = true;
        }
        if ((Armor == 10) || (SkillPoints < CellMembraneReq)){
            CellMembrane.interactable = false;
            Cilium.GetComponent<Image>().color = new Color (54, 69, 79);
        } else {
            CellMembrane.interactable = true;
        }
       /* if (EvolutionPoints == 0) //checking of EP
        {
            Speed1.GetComponent<Button>().enabled = false;
        } 
        else 
        {
            Speed1.GetComponent<Button>().enabled = true;
        }
        if ((Speed1lvl  == 5) || (EvolutionPoints < Speed1Req)) //To cap skill level
        {
            Speed1.interactable = false;
        }
        else 
        {
            Speed1.interactable = true;
        }
        if (EvolutionPoints <= 4)
        {
            SFGen.GetComponent<Button>().enabled = false;
        } 
        else 
        {
            SFGen.GetComponent<Button>().enabled = true; 
        }
        if ((SFGenlvl  == 5) || (EvolutionPoints < SFGenReq)) //To cap skill level
        {
            SFGen.interactable = false;
        }
        else
        {
            SFGen.interactable = true;
        }
        if ((EvolutionPoints <= 2) || (TotalSpentEP < 6))
        {
            //Speed2.GetComponent<Button>().enabled = false; //old code
            Speed2.interactable = false;
        } 
        if ((EvolutionPoints >= 3) && (TotalSpentEP > 5))
        {
            //Speed2.GetComponent<Button>().enabled = true;
            Speed2.interactable = true;
        }
        if (Speed2lvl  == 5) //To cap skill level
        {
            Speed2.interactable = false;
        }*/

    }
    public void CiliumGet() 
    {
        MvmSpeed.Speed += 0.2f;
        SkillPoints -= CiliumReq;
        TotalSpentSP += CiliumReq;
        CiliumReq += 1;
        Debug.Log(MvmSpeed.Speed+" "+SkillPoints+" "+CiliumReq);
        Cilium.GetComponent<Image>().color = new Color (0,1,0);
        Ciliumlvl++;
        CiliumText.GetComponent<Text>().text = Ciliumlvl.ToString();

        /*
        PlayerSpeed += 0.2f;
        EvolutionPoints -= Speed1Req;
        TotalSpentEP += Speed1Req;
        Speed1Req += 1;
        Debug.Log(PlayerSpeed+" "+EvolutionPoints+" "+Speed1Req);
        Speed1.GetComponent<Image>().color = new Color (0,1,0); //when skill is bought it changes color to show
        Speed1lvl += 1;
        Speed1SL.GetComponent<Text>().text = Speed1lvl.ToString(); //skill level, if it says error cuz its int to string just add - .ToString()
        */
        
    }
    public void CellMembraneGet() //autotroph 
    {
        Armor += 1;
        SkillPoints -= CellMembraneReq;
        TotalSpentSP += CellMembraneReq;
        CellMembraneReq += 1;
        Debug.Log(Armor+" "+SkillPoints+" "+CellMembraneReq);
        CellMembrane.GetComponent<Image>().color = new Color (0,1,0);
        CellMembranelvl++;
        CellMembraneText.GetComponent<Text>().text = CellMembranelvl.ToString();
    }
    public void FlagellaGet() //tier2 speed increase
    {
        MvmSpeed.Speed += 0.2f;
        SkillPoints -= FlagellaReq;
        TotalSpentSP += FlagellaReq;
        FlagellaReq += 1;
        Debug.Log(MvmSpeed.Speed+" "+SkillPoints+" "+FlagellaReq);
        Flagella.GetComponent<Image>().color = new Color (0,1,0);
        Flagellalvl++;
        FlagellaText.GetComponent<Text>().text = Flagellalvl.ToString();
    }
    public void UnHover()
    {
        skillNameTxt.enabled = false;
        skillDescTxt.enabled = false;
    }
    public void HoverCilia()
    {
        skillNameTxt.enabled = true;
        skillDescTxt.enabled = true;
        skillNameTxt.GetComponent<Text>().text = "Cilia";
        skillDescTxt.GetComponent<Text>().text = "Cell gains a hair-like projections on its body\n\n\n" + "Increases Speed by 0.2";
    }
    public void HoverCellMembrane()
    {
        skillNameTxt.enabled = true;
        skillDescTxt.enabled = true;
        skillNameTxt.GetComponent<Text>().text = "Cell Membrane";
        skillDescTxt.GetComponent<Text>().text = "Cell enhances its own Cell Membrane \n\n\n" + "Increases Armor by 1";
    }
    public void HoverFlagella()
    {
        skillNameTxt.enabled = true;
        skillDescTxt.enabled = true;
        skillNameTxt.GetComponent<Text>().text = "Flagella";
        skillDescTxt.GetComponent<Text>().text = "Cell gains a tail-like structure on its body\n\n\n" + "Increases Speed by 0.2";
    }
}

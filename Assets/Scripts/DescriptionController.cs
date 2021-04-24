using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DescriptionController : MonoBehaviour
{
    public GameObject CityGuardFunding1;
    public GameObject CityGuardFunding2;
    public GameObject CityGuardFunding3;
    public GameObject PublicPunishments;
    public GameObject JailDissenters;
    public GameObject JailFunding;
    public GameObject WasteCollection;
    public GameObject SanitizationWorkers;
    public GameObject Plumbing;
    public GameObject PublicCourtyards;
    public GameObject PublicGardens;
    public GameObject FundingForArts;
    public GameObject ThreeCropSystems;
    public GameObject FarmerLandAllotments;
    public GameObject IrrigationSystems;
    public GameObject TaxIncrease1;
    public GameObject TaxIncrease2;
    public GameObject TaxIncrease3;
    public GameObject TrainCraftsmen;
    public GameObject ExportGoods;
    public GameObject withdraw;

    public void onClickfunding1() {
        CityGuardFunding1.SetActive(true);
        CityGuardFunding2.SetActive(false);
        CityGuardFunding3.SetActive(false);
        JailFunding.SetActive(false);
        PublicPunishments.SetActive(false);
        JailDissenters.SetActive(false);
            }
    public void onClickfunding2() {
        CityGuardFunding1.SetActive(false);
        CityGuardFunding2.SetActive(true);
        CityGuardFunding3.SetActive(false);
        JailFunding.SetActive(false);
        PublicPunishments.SetActive(false);
        JailDissenters.SetActive(false);
    }
    public void onClickfunding3() {
        CityGuardFunding1.SetActive(false);
        CityGuardFunding2.SetActive(false);
        CityGuardFunding3.SetActive(true);
        JailFunding.SetActive(false);
        PublicPunishments.SetActive(false);
        JailDissenters.SetActive(false);      
        }
    public void onClickJailFunding() {
        CityGuardFunding1.SetActive(false);
        CityGuardFunding2.SetActive(false);
        CityGuardFunding3.SetActive(false);
        JailFunding.SetActive(true);
        PublicPunishments.SetActive(false);
        JailDissenters.SetActive(false);
            }
    public void onClickPublicPunishments() {
        CityGuardFunding1.SetActive(false);
        CityGuardFunding2.SetActive(false);
        CityGuardFunding3.SetActive(false);
        JailFunding.SetActive(false);
        PublicPunishments.SetActive(true);
        JailDissenters.SetActive(false);   
    }
    public void onClickJailDissenters() {
        CityGuardFunding1.SetActive(false);
        CityGuardFunding2.SetActive(false);
        CityGuardFunding3.SetActive(false);
        JailFunding.SetActive(false);
        PublicPunishments.SetActive(false);
        JailDissenters.SetActive(true);
    }

    public void onClickWasteCollection() {
        WasteCollection.SetActive(true);
        SanitizationWorkers.SetActive(false);
        Plumbing.SetActive(false);
        PublicCourtyards.SetActive(false);
        PublicGardens.SetActive(false);
        FundingForArts.SetActive(false);
        ThreeCropSystems.SetActive(false);
        FarmerLandAllotments.SetActive(false);
        IrrigationSystems.SetActive(false);
    }
    public void onClickSanitizationWorkers() {
        WasteCollection.SetActive(false);
        SanitizationWorkers.SetActive(true);
        Plumbing.SetActive(false);
        PublicCourtyards.SetActive(false);
        PublicGardens.SetActive(false);
        FundingForArts.SetActive(false);
        ThreeCropSystems.SetActive(false);
        FarmerLandAllotments.SetActive(false);
        IrrigationSystems.SetActive(false);     
    }
    public void onClickPlumbing() {
        WasteCollection.SetActive(false);
        SanitizationWorkers.SetActive(false);
        Plumbing.SetActive(true);
        PublicCourtyards.SetActive(false);
        PublicGardens.SetActive(false);
        FundingForArts.SetActive(false);
        ThreeCropSystems.SetActive(false);
        FarmerLandAllotments.SetActive(false);
        IrrigationSystems.SetActive(false);       
    }
    public void onClickPublicCourtyards() {
        WasteCollection.SetActive(false);
        SanitizationWorkers.SetActive(false);
        Plumbing.SetActive(false);
        PublicCourtyards.SetActive(true);
        PublicGardens.SetActive(false);
        FundingForArts.SetActive(false);
        ThreeCropSystems.SetActive(false);
        FarmerLandAllotments.SetActive(false);
        IrrigationSystems.SetActive(false);       
    }
    public void onClickPublicGardens() {
        WasteCollection.SetActive(false);
        SanitizationWorkers.SetActive(false);
        Plumbing.SetActive(false);
        PublicCourtyards.SetActive(false);
        PublicGardens.SetActive(true);
        FundingForArts.SetActive(false);
        ThreeCropSystems.SetActive(false);
        FarmerLandAllotments.SetActive(false);
        IrrigationSystems.SetActive(false);
    }
    public void onClickFundingForArts() {
        WasteCollection.SetActive(false);
        SanitizationWorkers.SetActive(false);
        Plumbing.SetActive(false);
        PublicCourtyards.SetActive(false);
        PublicGardens.SetActive(false);
        FundingForArts.SetActive(true);
        ThreeCropSystems.SetActive(false);
        FarmerLandAllotments.SetActive(false);
        IrrigationSystems.SetActive(false);      
    }
    public void onClickThreeCropSystems() {
        WasteCollection.SetActive(false);
        SanitizationWorkers.SetActive(false);
        Plumbing.SetActive(false);
        PublicCourtyards.SetActive(false);
        PublicGardens.SetActive(false);
        FundingForArts.SetActive(false);
        ThreeCropSystems.SetActive(true);
        FarmerLandAllotments.SetActive(false);
        IrrigationSystems.SetActive(false);
        }
    public void onClickFarmerLandAllotments() {
        WasteCollection.SetActive(false);
        SanitizationWorkers.SetActive(false);
        Plumbing.SetActive(false);
        PublicCourtyards.SetActive(false);
        PublicGardens.SetActive(false);
        FundingForArts.SetActive(false);
        ThreeCropSystems.SetActive(false);
        FarmerLandAllotments.SetActive(true);
        IrrigationSystems.SetActive(false);
    }
    public void onClickIrrigationSystem() {
        WasteCollection.SetActive(false);
        SanitizationWorkers.SetActive(false);
        Plumbing.SetActive(false);
        PublicCourtyards.SetActive(false);
        PublicGardens.SetActive(false);
        FundingForArts.SetActive(false);
        ThreeCropSystems.SetActive(false);
        FarmerLandAllotments.SetActive(false);
        IrrigationSystems.SetActive(true);
    }
    public void onClickTaxIncrease1() {
        TaxIncrease1.SetActive(true);
        TaxIncrease2.SetActive(false);
        TaxIncrease3.SetActive(false);
        TrainCraftsmen.SetActive(false);
        ExportGoods.SetActive(false);        
    }
    public void onClickTaxIncrease2() {
        TaxIncrease1.SetActive(false);
        TaxIncrease2.SetActive(true);
        TaxIncrease3.SetActive(false);
        TrainCraftsmen.SetActive(false);
        ExportGoods.SetActive(false);        
}
    public void onClickTaxIncrease3() {
        TaxIncrease1.SetActive(false);
        TaxIncrease2.SetActive(false);
        TaxIncrease3.SetActive(true);
        TrainCraftsmen.SetActive(false);
        ExportGoods.SetActive(false);        
}
    public void onClickTrainCraftsmen() {
        TaxIncrease1.SetActive(false);
        TaxIncrease2.SetActive(false);
        TaxIncrease3.SetActive(false);
        TrainCraftsmen.SetActive(true);
        ExportGoods.SetActive(false); 
}
    public void onClickExportGoods() {
        TaxIncrease1.SetActive(false);
        TaxIncrease2.SetActive(false);
        TaxIncrease3.SetActive(false);
        TrainCraftsmen.SetActive(false);
        ExportGoods.SetActive(true); 
    }
    public void onClickwithdraw() {
        TaxIncrease1.SetActive(false);
        TaxIncrease2.SetActive(false);
        TaxIncrease3.SetActive(false);
        TrainCraftsmen.SetActive(false);
        ExportGoods.SetActive(false); 
        CityGuardFunding1.SetActive(false);
        CityGuardFunding2.SetActive(false);
        CityGuardFunding3.SetActive(false);
        JailFunding.SetActive(false);
        PublicPunishments.SetActive(false);
        JailDissenters.SetActive(false);
        WasteCollection.SetActive(false);
        SanitizationWorkers.SetActive(false);
        Plumbing.SetActive(false);
        PublicCourtyards.SetActive(false);
        PublicGardens.SetActive(false);
        FundingForArts.SetActive(false);
        ThreeCropSystems.SetActive(false);
        FarmerLandAllotments.SetActive(false);
        IrrigationSystems.SetActive(false);
    }
}

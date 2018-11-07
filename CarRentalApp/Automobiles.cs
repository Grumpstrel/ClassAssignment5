using System;
using System.Collections.Generic;
using System.Text;

namespace CarRentalApp
{
    #region VehicleEnumInfo
    enum VehicleRentalClassification
    {
        Luxury,
        Premium,
        MidRange,
        Economy,
        SubCompact
    }

    enum VehicleTypeClassification
    {
        Sedan,
        Wagon,
        SportsCar,
        SubCompact,
        Coupe,
        SmallPickup,
        FullSizePickup,
        SmallSUV,
        FullSizeSUV
    }

    enum VehicleMake
    {
        Chevrolet,
        Ford,
        Dodge,
        BMW,
        Cadillac,
        Kia,
        Hyundai,
        Subaru,
    }

    enum VehicleModel
    {
        Impala,
        CTSWagon,
        Outback,
        Corvette,
        Fiesta,
        Rio,
        M3,
        Colorado,
        Silverado,
        F150,
        Sportage,
        Escape,
        Tahoe,
        Suburban,
        Expedition
    }

    enum VehicleFeatures
    {
        CruiseControl,
        GPS,
        OnStar,
        Sunroof,
        Tint
    }
    #endregion
    class Automobiles
    {
        #region Properties
        public VehicleRentalClassification VehicleRentalClassificaiton { get; set; }
        public VehicleTypeClassification VehicleTypeClassification { get; set; }
        public VehicleMake VehicleMake { get; set; }
        public VehicleModel VehicleModel { get; set; }
        public VehicleFeatures VehicleFeatures { get; set; }

        #endregion


    }
}

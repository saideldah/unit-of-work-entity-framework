using System;

namespace DataAccessLayer
{
    public static class DataConstants
    {
        #region Statuses Definition
        public static Guid STATUS_RECALL = new Guid("{A42F116A-07C2-4269-8CD2-8919C0F328EE}");
        public static Guid STATUS_SCHEDULED = new Guid("{13C0AE2A-C4C9-457F-A9C1-F4896D496A9C}");
        public static Guid STATUS_CANCELED = new Guid("{F5E5BC7C-EC6B-4FA8-A013-DBD586D1BE7E}");
        public static Guid STATUS_ABSENT = new Guid("{CDCC1DC4-8446-4FC0-B164-E9FA5F1A9BDA}");
        public static Guid STATUS_ARRIVED = new Guid("{BBF811E7-44DC-4619-8EA8-1EB7EEEF3E0C}");
        public static Guid STATUS_CHECKIN = new Guid("{45406D90-E510-4739-8E4C-BAEE523799D7}");
        public static Guid STATUS_COMPLETED = new Guid("{94220945-CAB7-492F-9338-5BFF2C1A3BAB}");
        #endregion

        #region Status Types
        public static Guid STATUS_TYPE_APPOINTMENT = new Guid("{553AFA9C-F222-4F37-B6B3-44DCA9EF54FD}");
        #endregion
    }
}

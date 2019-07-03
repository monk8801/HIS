using System;
using System.Collections;
using System.Collections.Generic;
using System.Text;
using System.Data;
using com.digitalwave.iCare.ValueObject;
using com.digitalwave.iCare.middletier.HIS;

namespace com.digitalwave.iCare.gui.HIS
{
    /// <summary>
    /// ����DOMIAN��
    /// </summary>
    public class clsDcl_Charge : com.digitalwave.GUI_Base.clsDomainController_Base
    {
        #region ����
        /// <summary>
        /// ����
        /// </summary>
        public clsDcl_Charge()
        {
        }
        #endregion

        #region ����Ա��ID��ȡ��������Ϣ
        /// <summary>
        /// ����Ա��ID��ȡ��������Ϣ
        /// </summary>
        /// <param name="EmpID">Ա��ID</param>
        /// <param name="dt"></param>
        /// <returns></returns>
        public long m_lngGetGroupEmp(string EmpID, out DataTable dt)
        {
            com.digitalwave.iCare.middletier.baseInfo.clsEmployeeSvc objSvc =
                                                           (com.digitalwave.iCare.middletier.baseInfo.clsEmployeeSvc)com.digitalwave.iCare.common.clsObjectGenerator.objCreatorObjectByType(typeof(com.digitalwave.iCare.middletier.baseInfo.clsEmployeeSvc));

            long l = objSvc.m_lngGetGroupEmp(EmpID, out dt);
            objSvc.Dispose();

            return l;
        }
        #endregion

        #region ���ݷ��෶Χ��ȡ���÷���(������㡢��Ʊ��סԺ���㡢��Ʊ)������Ϣ
        /// <summary>
        /// ���ݷ��෶Χ��ȡ���÷���(������㡢��Ʊ��סԺ���㡢��Ʊ)������Ϣ
        /// </summary>
        /// <param name="Scope">��Χ: 1 ������� 2 ���﷢Ʊ 3 סԺ���� 4 סԺ��Ʊ</param>
        /// <param name="Status">% ȫ�� 0 ͣ�� 1 ����</param>
        /// <param name="dt"></param>
        /// <returns></returns>
        public long m_lngGetDefChargeCat(string Scope, string Status, out DataTable dt)
        {
            com.digitalwave.iCare.middletier.HIS.clsCharge objSvc =
                                                           (com.digitalwave.iCare.middletier.HIS.clsCharge)com.digitalwave.iCare.common.clsObjectGenerator.objCreatorObjectByType(typeof(com.digitalwave.iCare.middletier.HIS.clsCharge));

            long l = objSvc.m_lngGetDefChargeCat(Scope, Status, out dt);
            objSvc.Dispose();

            return l;
        }
        #endregion

        #region ��ȡ����(�ѱ�)��Ϣ
        /// <summary>
        /// ��ȡ����(�ѱ�)��Ϣ
        /// </summary>
        /// <param name="dt"></param>
        /// <returns></returns>        
        public long m_lngGetPayTypeInfo(out DataTable dt)
        {
            com.digitalwave.iCare.middletier.HIS.clsCommonQuery objSvc =
                                                                (com.digitalwave.iCare.middletier.HIS.clsCommonQuery)com.digitalwave.iCare.common.clsObjectGenerator.objCreatorObjectByType(typeof(com.digitalwave.iCare.middletier.HIS.clsCommonQuery));

            long l = objSvc.m_lngGetPayTypeInfo(out dt);
            objSvc.Dispose();

            return l;
        }
        #endregion

        #region ��ȡԱ�������
        /// <summary>
        /// ��ȡԱ�������
        /// </summary>
        /// <param name="dt"></param>
        /// <returns></returns>        
        public long m_lngGetEmployee(out DataTable dt)
        {
            com.digitalwave.iCare.middletier.HIS.clsCharge objSvc =
                                                           (com.digitalwave.iCare.middletier.HIS.clsCharge)com.digitalwave.iCare.common.clsObjectGenerator.objCreatorObjectByType(typeof(com.digitalwave.iCare.middletier.HIS.clsCharge));

            long l = objSvc.m_lngGetEmployee(out dt);
            objSvc.Dispose();

            return l;
        }
        /// <summary>
        /// ��ȡԱ�������
        /// </summary>
        /// <param name="dt"></param>
        /// <param name="empTypeId"></param>
        /// <returns></returns>
        public long m_lngGetEmployee(out DataTable dt, int empTypeId)
        {
            com.digitalwave.iCare.middletier.HIS.clsCharge objSvc =
                                                           (com.digitalwave.iCare.middletier.HIS.clsCharge)com.digitalwave.iCare.common.clsObjectGenerator.objCreatorObjectByType(typeof(com.digitalwave.iCare.middletier.HIS.clsCharge));

            long l = objSvc.m_lngGetEmployee(out dt, empTypeId);
            objSvc.Dispose();

            return l;
        }
        #endregion

        #region ����Ա�����Ż�ȡID������
        /// <summary>
        /// ����Ա�����Ż�ȡID������
        /// </summary>
        /// <param name="EmpCode"></param>
        /// <param name="EmpID"></param>
        /// <param name="EmpName"></param>
        /// <returns></returns>
        public long m_lngGetEmployee(string EmpCode, out string EmpID, out string EmpName)
        {
            com.digitalwave.iCare.middletier.HIS.clsCharge objSvc =
                                                           (com.digitalwave.iCare.middletier.HIS.clsCharge)com.digitalwave.iCare.common.clsObjectGenerator.objCreatorObjectByType(typeof(com.digitalwave.iCare.middletier.HIS.clsCharge));

            long l = objSvc.m_lngGetEmployee(EmpCode, out EmpID, out EmpName);
            objSvc.Dispose();

            return l;
        }
        #endregion

        #region �����û�ID��ȡ������ɫ�б�
        /// <summary>
        /// �����û�ID��ȡ������ɫ�б�
        /// </summary>
        /// <param name="EmpID"></param>
        /// <param name="dt"></param>
        /// <returns></returns>        
        public long m_lngGetEmpRole(string EmpID, out DataTable dt)
        {
            com.digitalwave.iCare.middletier.HIS.clsCommonQuery objSvc =
                                                 (com.digitalwave.iCare.middletier.HIS.clsCommonQuery)com.digitalwave.iCare.common.clsObjectGenerator.objCreatorObjectByType(typeof(com.digitalwave.iCare.middletier.HIS.clsCommonQuery));

            long l = objSvc.m_lngGetEmpRole(EmpID, out dt);
            objSvc.Dispose();

            return l;
        }
        #endregion

        #region ��ò�����Ϣ
        /// <summary>
        /// ��ò�����Ϣ
        /// </summary>
        /// <param name="dt"></param>
        /// <param name="Flag">1 ���� 2 ����</param>
        /// <returns></returns>
        public long m_lngGetDeptArea(out DataTable dt, int Flag)
        {
            com.digitalwave.iCare.middletier.HIS.clsCommonQuery objSvc =
                                                 (com.digitalwave.iCare.middletier.HIS.clsCommonQuery)com.digitalwave.iCare.common.clsObjectGenerator.objCreatorObjectByType(typeof(com.digitalwave.iCare.middletier.HIS.clsCommonQuery));

            long l = objSvc.m_lngGetDeptArea(out dt, Flag);
            objSvc.Dispose();

            return l;
        }
        #endregion

        #region ���ݲ���ID�ʹ���ID(��CODE)��ȡסԺ��
        /// <summary>
        /// ���ݲ���ID�ʹ���ID(��CODE)��ȡסԺ��
        /// </summary>
        /// <param name="AreaID">����ID</param>
        /// <param name="BedID">����ID(��CODE)</param>          
        /// <returns></returns>        
        public string m_strGetZyhByAreaAndBedID(string AreaID, string BedID)
        {
            com.digitalwave.iCare.middletier.HIS.clsCommonQuery objSvc =
                                                           (com.digitalwave.iCare.middletier.HIS.clsCommonQuery)com.digitalwave.iCare.common.clsObjectGenerator.objCreatorObjectByType(typeof(com.digitalwave.iCare.middletier.HIS.clsCommonQuery));

            string s = objSvc.m_strGetZyhByAreaAndBedID(AreaID, BedID);
            objSvc.Dispose();

            return s;
        }
        #endregion

        #region ����סԺ�Ż����ƿ��Ż�ȡ������Ϣ
        /// <summary>
        /// ����סԺ�Ż����ƿ��Ż�ȡ������Ϣ
        /// </summary>
        /// <param name="no"></param>
        /// <param name="dt"></param>
        /// <param name="flag">0 ���� 1 ��Ժ 2 ��Ժ 3 ����</param>
        /// <param name="type">0 ���ƿ��Ż�סԺ�� 1 ���ƿ���  2 סԺ�� </param>
        /// <returns></returns>
        public long m_lngGetPatientinfoByNO(string no, out DataTable dt, int flag, int type)
        {
            com.digitalwave.iCare.middletier.HIS.clsCommonQuery objSvc =
                                                 (com.digitalwave.iCare.middletier.HIS.clsCommonQuery)com.digitalwave.iCare.common.clsObjectGenerator.objCreatorObjectByType(typeof(com.digitalwave.iCare.middletier.HIS.clsCommonQuery));

            long l = objSvc.m_lngGetPatientinfoByNO(no, out dt, flag, type);
            objSvc.Dispose();

            return l;
        }
        #endregion

        #region  ���ҳ�Ժ���˴���
        /// <summary>
        /// ���ҳ�Ժ���˴���
        /// </summary>
        /// <param name="no"></param>
        /// <param name="type"></param>
        /// <param name="p_strBedNo"></param>
        /// <returns></returns>
        public long m_lngGetDedNo(string no, ref string p_strBedNo)
        {
            com.digitalwave.iCare.middletier.HIS.clsCommonQuery objSvc =
                                                           (com.digitalwave.iCare.middletier.HIS.clsCommonQuery)com.digitalwave.iCare.common.clsObjectGenerator.objCreatorObjectByType(typeof(com.digitalwave.iCare.middletier.HIS.clsCommonQuery));

            long l = objSvc.m_lngGetDedNo(no, ref p_strBedNo);
            objSvc.Dispose();
            return l;
        }
        #endregion

        #region ����סԺ�Ǽ���ˮ�Ų��Ҳ�������������Ϣ
        /// <summary>
        /// ����סԺ�Ǽ���ˮ�Ų��Ҳ�������������Ϣ
        /// </summary>
        /// <param name="RegID"></param>
        /// <param name="dt"></param>
        /// <returns></returns>
        public long m_lngGetPatientDayaccountsByRegID(string RegID, out DataTable dt)
        {
            com.digitalwave.iCare.middletier.HIS.clsCharge objSvc =
                                                 (com.digitalwave.iCare.middletier.HIS.clsCharge)com.digitalwave.iCare.common.clsObjectGenerator.objCreatorObjectByType(typeof(com.digitalwave.iCare.middletier.HIS.clsCharge));

            long l = objSvc.m_lngGetPatientDayaccountsByRegID(RegID, out dt);
            objSvc.Dispose();

            return l;
        }
        #endregion

        #region ��ȡ��������Ч������Ϣ
        /// <summary>
        /// ��ȡ��������Ч������Ϣ
        /// </summary>
        /// <param name="ID"></param>
        /// <param name="type">1 ������Ժ�Ǽ�ID 2 ��������ID </param>
        /// <param name="dt"></param>
        /// <returns></returns>
        public long m_lngGetChargeInfoByID(string ID, int type, out DataTable dt)
        {
            com.digitalwave.iCare.middletier.HIS.clsCharge objSvc =
                                                 (com.digitalwave.iCare.middletier.HIS.clsCharge)com.digitalwave.iCare.common.clsObjectGenerator.objCreatorObjectByType(typeof(com.digitalwave.iCare.middletier.HIS.clsCharge));

            long l = objSvc.m_lngGetChargeInfoByID(ID, type, out dt);
            objSvc.Dispose();

            return l;
        }
        #endregion

        #region ĸӤ�ϲ��������һ���ѯucpatien�ؼ�ʹ��
        /// <summary>
        /// ĸӤ�ϲ��������һ���ѯucpatien�ؼ�ʹ��
        /// </summary>
        /// <param name="p_strRegisterID">����registerId</param>
        /// <param name="p_dtbCharge"></param>
        /// <returns></returns>
        public long m_lngGetChargeInfoByIDForBaby(string p_strRegisterID, out DataTable p_dtbCharge)
        {
            com.digitalwave.iCare.middletier.HIS.clsCharge objSvc =
                                                 (com.digitalwave.iCare.middletier.HIS.clsCharge)com.digitalwave.iCare.common.clsObjectGenerator.objCreatorObjectByType(typeof(com.digitalwave.iCare.middletier.HIS.clsCharge));

            long lngRes = objSvc.m_lngGetChargeInfoByIDForBaby(p_strRegisterID, out p_dtbCharge);
            objSvc.Dispose();
            objSvc = null;
            return lngRes;
        }
        #endregion


        #region ��ȡ��Ŀ������Ϣ(������ࡢ��Ʊ����)
        /// <summary>
        /// ��ȡ��Ŀ������Ϣ(������ࡢ��Ʊ����)
        /// </summary>
        /// <param name="flag">�������ͣ�1 ������� 2 ���﷢Ʊ 3 סԺ���� 4 סԺ��Ʊ 5 ��������</param>
        /// <param name="dt"></param>
        /// <returns></returns>              
        public long m_lngGetChargeItemCat(int flag, out DataTable dt)
        {
            com.digitalwave.iCare.middletier.HIS.clsCharge objSvc =
                                                 (com.digitalwave.iCare.middletier.HIS.clsCharge)com.digitalwave.iCare.common.clsObjectGenerator.objCreatorObjectByType(typeof(com.digitalwave.iCare.middletier.HIS.clsCharge));

            long l = objSvc.m_lngGetChargeItemCat(flag, out dt);
            objSvc.Dispose();

            return l;
        }
        #endregion

        #region ����סԺ�Ǽ���ˮ�ż����Ŀ״̬
        /// <summary>
        /// ����סԺ�Ǽ���ˮ�ż����Ŀ״̬
        /// </summary>
        /// <param name="RegID">סԺ�Ǽ���ˮ��</param>
        /// <param name="status">0=��ȷ��;1=����;2=����;3=����;4=ֱ��</param>
        /// <returns></returns>
        public bool m_blnCheckChargeItemStatus(string RegID, int status)
        {
            com.digitalwave.iCare.middletier.HIS.clsCharge objSvc =
                                                 (com.digitalwave.iCare.middletier.HIS.clsCharge)com.digitalwave.iCare.common.clsObjectGenerator.objCreatorObjectByType(typeof(com.digitalwave.iCare.middletier.HIS.clsCharge));

            bool b = objSvc.m_blnCheckChargeItemStatus(RegID, status);
            objSvc.Dispose();

            return b;
        }
        #endregion

        #region ����סԺ�Ǽ���ˮ�����ɸ�״̬��Ŀ�ܷ���
        /// <summary>
        /// ����סԺ�Ǽ���ˮ�����ɸ�״̬��Ŀ�ܷ���
        /// </summary>
        /// <param name="RegID">סԺ�Ǽ���ˮ��</param>
        /// <param name="status">0 ��ȷ�� 1 ���� 2 ���� 3 ���� 4 ֱ�� 9 ��������</param>
        /// <param name="dt"></param>
        /// <returns></returns>
        public long m_lngGetChargeItemFee(string RegID, int status, out DataTable dt)
        {
            com.digitalwave.iCare.middletier.HIS.clsCharge objSvc =
                                                             (com.digitalwave.iCare.middletier.HIS.clsCharge)com.digitalwave.iCare.common.clsObjectGenerator.objCreatorObjectByType(typeof(com.digitalwave.iCare.middletier.HIS.clsCharge));

            long l = objSvc.m_lngGetChargeItemFee(RegID, status, out dt);
            objSvc.Dispose();

            return l;
        }
        #endregion

        #region ��鷢Ʊ���Ƿ��ظ�
        /// <summary>
        /// ��鷢Ʊ���Ƿ��ظ�
        /// </summary>
        /// <param name="CurrNo"></param>
        /// <returns></returns>
        public bool m_blnCheckInvoiceNo(string CurrNo)
        {
            com.digitalwave.iCare.middletier.HIS.clsCharge objSvc =
                                                 (com.digitalwave.iCare.middletier.HIS.clsCharge)com.digitalwave.iCare.common.clsObjectGenerator.objCreatorObjectByType(typeof(com.digitalwave.iCare.middletier.HIS.clsCharge));

            bool b = objSvc.m_blnCheckInvoiceNo(CurrNo);
            objSvc.Dispose();

            return b;
        }
        #endregion

        #region ������Ժ�Ǽ���ˮID��ȡ�����𡢴�λ������ʱ��
        /// <summary>
        /// ������Ժ�Ǽ���ˮID��ȡ�����𡢴�λ������ʱ��
        /// </summary>
        /// <param name="RegID"></param>
        /// <param name="FinallyDate"></param>
        /// <returns></returns>
        public long m_lngGetFinallyDiagFeeDateByRegID(string RegID, out string FinallyDate)
        {
            com.digitalwave.iCare.middletier.HIS.clsCharge objSvc =
                                                             (com.digitalwave.iCare.middletier.HIS.clsCharge)com.digitalwave.iCare.common.clsObjectGenerator.objCreatorObjectByType(typeof(com.digitalwave.iCare.middletier.HIS.clsCharge));

            long l = objSvc.m_lngGetFinallyDiagFeeDateByRegID(RegID, out FinallyDate);
            objSvc.Dispose();

            return l;
        }
        #endregion

        #region ������Ժ�Ǽ���ˮ�Ż�ȡԤ��Ժʱ��
        /// <summary>
        /// ������Ժ�Ǽ���ˮ�Ż�ȡԤ��Ժʱ��
        /// </summary>
        /// <param name="RegID"></param>
        /// <param name="PrepDate"></param>
        /// <returns></returns>
        public long m_lngGetPrepLHDateByRegID(string RegID, out string PrepDate)
        {
            com.digitalwave.iCare.middletier.HIS.clsCharge objSvc =
                                                             (com.digitalwave.iCare.middletier.HIS.clsCharge)com.digitalwave.iCare.common.clsObjectGenerator.objCreatorObjectByType(typeof(com.digitalwave.iCare.middletier.HIS.clsCharge));

            long l = objSvc.m_lngGetPrepLHDateByRegID(RegID, out PrepDate);
            objSvc.Dispose();

            return l;
        }
        #endregion

        #region ����
        /// <summary>
        /// ����
        /// </summary>
        /// <param name="dtSource"></param>
        /// <param name="DayChrgType">���ʽ������ͣ�1 ���� 2 ��ϸ</param>
        /// <param name="DayAccountsArr"></param>
        /// <param name="Charge_VO"></param>
        /// <param name="ChargeCatArr"></param>
        /// <param name="Invoice_VO"></param>
        /// <param name="InvoCatArr"></param>
        /// <param name="PaymentArr"></param>
        /// <param name="PrePayDeal">Ԥ�������� 0 ������ 1 �˻� 2 ת����</param> 
        /// <param name="PrePayIDArr"></param>
        /// <param name="ChrgType">�������ͣ�1 ��;���� 2 ��Ժ���� 3 ���ʽ���</param>
        /// <returns></returns>
        public long m_lngReckoning(DataTable dtSource, int DayChrgType, ArrayList DayAccountsArr, clsBihCharge_VO Charge_VO, ArrayList ChargeCatArr, clsBihInvoice_VO Invoice_VO, ArrayList InvoCatArr, ArrayList PaymentArr, int PrePayDeal, ArrayList PrePayIDArr, int ChargeType, clsBihConfirm_VO Confirm_VO, out string ChargeNo)
        {
            com.digitalwave.iCare.middletier.HIS.clsCharge objSvc =
                                                             (com.digitalwave.iCare.middletier.HIS.clsCharge)com.digitalwave.iCare.common.clsObjectGenerator.objCreatorObjectByType(typeof(com.digitalwave.iCare.middletier.HIS.clsCharge));

            long l = objSvc.m_lngReckoning(dtSource, DayChrgType, DayAccountsArr, Charge_VO, ChargeCatArr, Invoice_VO, InvoCatArr, PaymentArr, PrePayDeal, PrePayIDArr, ChargeType, Confirm_VO, out ChargeNo);
            objSvc.Dispose();

            return l;
        }
        #endregion

        #region �˿�
        /// <summary>
        /// �˿�
        /// </summary>
        /// <param name="ChargeNo"></param>
        /// <param name="Invono"></param>
        /// <param name="EmpID"></param>
        /// <param name="ChargeType">�������ͣ�1 ��;���� 2 ��Ժ���� 3 ���ʽ��� 4 ֱ�� 5 ȷ���շ� 6 ���ʲ��������</param>
        /// <returns></returns>
        public long m_lngRefundment(string ChargeNo, string Invono, string EmpID, int ChargeType, int PayMode)
        {
            com.digitalwave.iCare.middletier.HIS.clsCharge objSvc =
                                                             (com.digitalwave.iCare.middletier.HIS.clsCharge)com.digitalwave.iCare.common.clsObjectGenerator.objCreatorObjectByType(typeof(com.digitalwave.iCare.middletier.HIS.clsCharge));

            long l = objSvc.m_lngRefundment(ChargeNo, Invono, EmpID, ChargeType, PayMode);
            objSvc.Dispose();

            return l;
        }
        #endregion

        #region ���ݽ���Ż�ȡ��Ʊ��ϸ��Ϣ
        /// <summary>
        /// ���ݽ���Ż�ȡ��Ʊ��ϸ��Ϣ
        /// </summary>
        /// <param name="ChargeNo"></param>
        /// <param name="dtMain"></param>
        /// <param name="dtDet"></param>
        /// <param name="dtPrepay"></param>
        /// <returns></returns>
        public long m_lngGetInvoiceByChargeNo(string ChargeNo, out DataTable dtMain, out DataTable dtDet, out DataTable dtPrepay, out DataTable dtPayMode, out DataTable dtItemDate)
        {
            com.digitalwave.iCare.middletier.HIS.clsCharge objSvc =
                                                             (com.digitalwave.iCare.middletier.HIS.clsCharge)com.digitalwave.iCare.common.clsObjectGenerator.objCreatorObjectByType(typeof(com.digitalwave.iCare.middletier.HIS.clsCharge));

            long l = objSvc.m_lngGetInvoiceByChargeNo(ChargeNo, out dtMain, out dtDet, out dtPrepay, out dtPayMode, out dtItemDate);
            objSvc.Dispose();

            return l;
        }
        #endregion

        #region ������Ժ�Ǽ���ˮID��ȡ��Ʊ����Ϣ
        /// <summary>
        /// ������Ժ�Ǽ���ˮID��ȡ��Ʊ����Ϣ
        /// </summary>
        /// <param name="RegID"></param>
        /// <param name="Type">��Ʊ���ͷ�Χ��1 ���� 2 ����+�ش�</param>
        /// <param name="dt"></param>
        /// <returns></returns>
        public long m_lngGetInvoiceInfoByRegID(string RegID, int Type, out DataTable dt)
        {
            com.digitalwave.iCare.middletier.HIS.clsCharge objSvc =
                                                             (com.digitalwave.iCare.middletier.HIS.clsCharge)com.digitalwave.iCare.common.clsObjectGenerator.objCreatorObjectByType(typeof(com.digitalwave.iCare.middletier.HIS.clsCharge));

            long l = objSvc.m_lngGetInvoiceByRegID(RegID, Type, out dt);
            objSvc.Dispose();

            return l;
        }
        #endregion

        #region ��ѯ�շ���Ŀ
        /// <summary>
        /// ��ѯ�շ���Ŀ
        /// </summary>
        /// <param name="FindStr"></param>
        /// <param name="PatType">��������</param>
        /// <param name="dt"></param>
        /// <returns></returns>
        public long m_lngFindChargeItem(string FindStr, string PatType, out DataTable dt, bool isChildPrice)
        {
            com.digitalwave.iCare.middletier.HIS.clsCharge objSvc =
                                                           (com.digitalwave.iCare.middletier.HIS.clsCharge)com.digitalwave.iCare.common.clsObjectGenerator.objCreatorObjectByType(typeof(com.digitalwave.iCare.middletier.HIS.clsCharge));

            long l = objSvc.m_lngFindChargeItem(FindStr, PatType, out dt, isChildPrice);
            objSvc.Dispose();

            return l;
        }

        /// <summary>
        /// ������ĿID�����շ���Ŀ
        /// </summary>
        /// <param name="ItemID"></param>
        /// <param name="dt"></param>
        /// <returns></returns>
        public long m_lngFindChargeItem(string ItemID, out DataTable dt, bool isChildPrice)
        {
            com.digitalwave.iCare.middletier.HIS.clsCharge objSvc =
                                                           (com.digitalwave.iCare.middletier.HIS.clsCharge)com.digitalwave.iCare.common.clsObjectGenerator.objCreatorObjectByType(typeof(com.digitalwave.iCare.middletier.HIS.clsCharge));

            long l = objSvc.m_lngFindChargeItem(ItemID, out dt, isChildPrice);
            objSvc.Dispose();

            return l;
        }
        #endregion

        #region ֱ���շ����ɷ�����ϸ
        /// <summary>
        /// ֱ���շ����ɷ�����ϸ
        /// </summary>
        /// <param name="OrderDicArr">��������Ŀ����</param>
        /// <param name="PatientChargeArr">������ϸ����</param>
        /// <param name="Type">8 ֱ�� 9 ������</param>
        /// <param name="OrderID">���صķ���ID��(��ѽҽ�����ֶ�)</param>
        /// <returns></returns>        
        public long m_lngGenPatientChargeByDir(ArrayList OrderDicArr, ArrayList PatientChargeArr, int Type, ref string OrderID)
        {
            com.digitalwave.iCare.middletier.HIS.clsCharge objSvc =
                                                           (com.digitalwave.iCare.middletier.HIS.clsCharge)com.digitalwave.iCare.common.clsObjectGenerator.objCreatorObjectByType(typeof(com.digitalwave.iCare.middletier.HIS.clsCharge));

            long l = objSvc.m_lngGenPatientChargeByDir(OrderDicArr, PatientChargeArr, Type, ref OrderID);
            objSvc.Dispose();

            return l;
        }
        #endregion

        #region ����סԺ�Ǽ���ˮ�Ż�ȡ����Ч����(����״̬)������Ϣ
        /// <summary>
        /// ����סԺ�Ǽ���ˮ�Ż�ȡ����Ч����(����״̬)������Ϣ
        /// </summary>
        /// <param name="RegID">סԺ�Ǽ���ˮ��</param>
        /// <param name="ActiveType">��Ч����{1=����;2=������;3=ȷ�ϼ���;4=ȷ���շ�;5=ֱ���շ�;888=����״̬����;999=ȫ��}</param>
        /// <param name="dt"></param>
        /// <returns></returns>        
        public long m_lngGetFeeItemByActiveType(string RegID, int ActiveType, string Pstatus, string AreaID, string BeginDate, string EndDate, out DataTable dt)
        {
            com.digitalwave.iCare.middletier.HIS.clsChargeQuery objSvc =
                                                           (com.digitalwave.iCare.middletier.HIS.clsChargeQuery)com.digitalwave.iCare.common.clsObjectGenerator.objCreatorObjectByType(typeof(com.digitalwave.iCare.middletier.HIS.clsChargeQuery));

            long l = objSvc.m_lngGetFeeItemByActiveType(RegID, ActiveType, Pstatus, AreaID, BeginDate, EndDate, out dt);
            if (dt != null && dt.Rows.Count > 0)
            {
                #region Lis
                DataRow[] drr = null;
                DataTable dtRpt = objSvc.GetFeeItemByActiveTypeLis(dt);
                if (dtRpt != null && dtRpt.Rows.Count > 0)
                {
                    foreach (DataRow dr in dtRpt.Rows)
                    {
                        drr = dt.Select("orderid_chr = '" + dr["orderId"].ToString() + "'");
                        if (drr != null && drr.Length > 0)
                        {
                            foreach (DataRow dr1 in drr)
                            {
                                dr1["rptStatus"] = 1;
                            }
                        }
                    }
                    dt.AcceptChanges();
                }
                #endregion

                #region Pacs
                List<string> lstOrderId = objSvc.GetFeeItemByActiveTypePacs(dt);
                if (lstOrderId.Count > 0)
                {
                    foreach (string orderId in lstOrderId)
                    {
                        drr = dt.Select("orderid_chr = '" + orderId + "'");
                        if (drr != null && drr.Length > 0)
                        {
                            foreach (DataRow dr in drr)
                            {
                                dr["rptStatus"] = 1;
                            }
                        }
                    }
                }
                #endregion
            }

            objSvc.Dispose();
            return l;
        }
        #endregion

        #region ����ҽ��ID(ֱ�շ���ID)��ȡ������ϸ
        /// <summary>
        /// ����ҽ��ID(ֱ�շ���ID)��ȡ������ϸ
        /// </summary>
        /// <param name="ID"></param>
        /// <param name="dt"></param>
        /// <returns></returns>        
        public long m_lngGetPatientChargeByID(string ID, out DataTable dt)
        {
            com.digitalwave.iCare.middletier.HIS.clsCharge objSvc =
                                                           (com.digitalwave.iCare.middletier.HIS.clsCharge)com.digitalwave.iCare.common.clsObjectGenerator.objCreatorObjectByType(typeof(com.digitalwave.iCare.middletier.HIS.clsCharge));

            long l = objSvc.m_lngGetPatientChargeByID(ID, out dt);
            objSvc.Dispose();

            return l;
        }
        #endregion

        #region ��ȡ�շ���ĿĬ��ִ�еص�
        /// <summary>
        /// ��ȡ�շ���ĿĬ��ִ�еص�
        /// </summary>
        /// <param name="ItemID"></param>
        /// <param name="ApplyAreaID"></param>
        /// <returns></returns>        
        public string m_strGetChargeItemDefaultExecAreaID(string ItemID, string ApplyAreaID, out string ExecAreaName)
        {
            com.digitalwave.iCare.middletier.HIS.clsCharge objSvc =
                                                           (com.digitalwave.iCare.middletier.HIS.clsCharge)com.digitalwave.iCare.common.clsObjectGenerator.objCreatorObjectByType(typeof(com.digitalwave.iCare.middletier.HIS.clsCharge));

            string s = objSvc.m_strGetChargeItemDefaultExecAreaID(ItemID, ApplyAreaID, out ExecAreaName);
            objSvc.Dispose();

            return s;
        }
        #endregion

        #region �ύ�����ʷ�����ϸ
        /// <summary>
        /// �ύ�����ʷ�����ϸ
        /// </summary>
        /// <param name="OrderID"></param>
        /// <returns></returns>        
        public long m_lngCommitPatchCharge(string OrderID, string RegID, string OperID, int Type)
        {
            com.digitalwave.iCare.middletier.HIS.clsCharge objSvc =
                                                           (com.digitalwave.iCare.middletier.HIS.clsCharge)com.digitalwave.iCare.common.clsObjectGenerator.objCreatorObjectByType(typeof(com.digitalwave.iCare.middletier.HIS.clsCharge));

            long l = objSvc.m_lngCommitPatchCharge(OrderID, RegID, OperID, Type);
            objSvc.Dispose();

            return l;
        }
        #endregion

        #region �����ڹ���
        /// <summary>
        /// �����ڹ���
        /// </summary>
        /// <param name="ExecDate">����ʱ��(��ʽ��yyy-mm-dd hh:mm:ss</param>
        /// <param name="FeeDate">����ʱ��(��ʽ��yyy-mm-dd hh:mm:ss</param>
        /// <param name="OperID">����ԱID</param>   
        /// <param name="RegID">���˹���ʱ����Ժ�Ǽ�ID</param>  
        /// <param name="ExecType">1 ����ҹ�� 2 ��Ժ����</param>
        public long AutoCharge(string ExecDate, string FeeDate, string OperID, string RegID, int ExecType)
        {
            //com.digitalwave.iCare.middletier.HIS.clsAutoCharge objSvc =
            //                                               (com.digitalwave.iCare.middletier.HIS.clsAutoCharge)com.digitalwave.iCare.common.clsObjectGenerator.objCreatorObjectByType(typeof(com.digitalwave.iCare.middletier.HIS.clsAutoCharge));            

            //long l = objSvc.AutoCharge(ExecDate, OperID);
            //objSvc.Dispose();

            //com.digitalwave.iCare.middletier.HIS.clsAutoCharge_CS objSvc =
            //                                               (com.digitalwave.iCare.middletier.HIS.clsAutoCharge_CS)com.digitalwave.iCare.common.clsObjectGenerator.objCreatorObjectByType(typeof(com.digitalwave.iCare.middletier.HIS.clsAutoCharge_CS));

            com.digitalwave.iCare.middletier.HIS.clsAutoCharge_CS objSvc = new com.digitalwave.iCare.middletier.HIS.clsAutoCharge_CS();
            long l = objSvc.AutoCharge(ExecDate, FeeDate, OperID, clsPublic.m_intGetSysParm("1013"), clsPublic.m_intGetSysParm("1014"), RegID, ExecType);
            objSvc = null;

            return l;
        }
        #endregion

        #region ��Ժ��ȡ�����Է���
        /// <summary>
        /// ��Ժ��ȡ�����Է���
        /// </summary>
        /// <param name="FeeDate">����ʱ��(��ʽ��yyy-mm-dd hh:mm:ss)</param>
        /// <param name="OperID">����ԱID</param>
        /// <param name="RegID">��Ժ�Ǽ�ID</param>
        /// <returns></returns>
        public long AutoChargeContinueItem(string FeeDate, string OperID, string RegID)
        {
            //com.digitalwave.iCare.middletier.HIS.clsAutoCharge_CS objSvc =
            //                                               (com.digitalwave.iCare.middletier.HIS.clsAutoCharge_CS)com.digitalwave.iCare.common.clsObjectGenerator.objCreatorObjectByType(typeof(com.digitalwave.iCare.middletier.HIS.clsAutoCharge_CS));

            com.digitalwave.iCare.middletier.HIS.clsAutoCharge objSvc =
                                                               (com.digitalwave.iCare.middletier.HIS.clsAutoCharge)com.digitalwave.iCare.common.clsObjectGenerator.objCreatorObjectByType(typeof(com.digitalwave.iCare.middletier.HIS.clsAutoCharge));

            long l = objSvc.AutoChargeContinueItem(FeeDate, OperID, RegID);

            return l;
        }
        #endregion

        #region ��ȡ����������Ϣ
        /// <summary>
        /// ��ȡ����������Ϣ
        /// </summary>
        /// <param name="dt"></param>
        /// <returns></returns>        
        public long GetDayAccountsInfo(out DataTable dt)
        {
            com.digitalwave.iCare.middletier.HIS.clsAutoCharge objSvc =
                                                           (com.digitalwave.iCare.middletier.HIS.clsAutoCharge)com.digitalwave.iCare.common.clsObjectGenerator.objCreatorObjectByType(typeof(com.digitalwave.iCare.middletier.HIS.clsAutoCharge));

            long l = objSvc.GetDayAccountsInfo(out dt);
            objSvc.Dispose();

            return l;
        }
        #endregion

        #region ��ȡ�����������ʱ��
        /// <summary>
        /// ��ȡ�����������ʱ��
        /// </summary>
        /// <param name="RegID">��Ժ�Ǽ�ID</param>
        /// <returns></returns>        
        public string GetDayAccountsMaxDate(string RegID)
        {
            com.digitalwave.iCare.middletier.HIS.clsAutoCharge objSvc =
                                                           (com.digitalwave.iCare.middletier.HIS.clsAutoCharge)com.digitalwave.iCare.common.clsObjectGenerator.objCreatorObjectByType(typeof(com.digitalwave.iCare.middletier.HIS.clsAutoCharge));

            string s = objSvc.GetDayAccountsMaxDate(RegID);
            objSvc.Dispose();

            return s;
        }
        #endregion

        #region ��������
        /// <summary>
        /// ��������
        /// </summary>
        /// <param name="DayAccounts_VO">����VO</param>
        /// <param name="EmpID">����ԱID</param>       
        /// <param name="ChargeType">0 ��ͨ���� 1 ��Ժ���� 2 ��Ժ����</param>     
        /// <returns></returns>        
        public long m_lngBuildDayAccounts(clsBihDayAccounts_VO DayAccounts_VO, string EmpID, int ChargeType)
        {
            com.digitalwave.iCare.middletier.HIS.clsCharge objSvc =
                                                           (com.digitalwave.iCare.middletier.HIS.clsCharge)com.digitalwave.iCare.common.clsObjectGenerator.objCreatorObjectByType(typeof(com.digitalwave.iCare.middletier.HIS.clsCharge));

            long l = objSvc.m_lngBuildDayAccounts(DayAccounts_VO, EmpID, ChargeType);
            objSvc.Dispose();

            return l;
        }
        #endregion

        #region ������
        /// <summary>
        /// ������
        /// </summary>
        /// <param name="PatientChargeArr">������ϸ����</param>        
        /// <param name="DayAccountID">����ID</param>                
        /// <returns></returns>        
        public long m_lngPatchDayAccount(ArrayList PatientChargeArr, string DayAccountID)
        {
            com.digitalwave.iCare.middletier.HIS.clsCharge objSvc =
                                                           (com.digitalwave.iCare.middletier.HIS.clsCharge)com.digitalwave.iCare.common.clsObjectGenerator.objCreatorObjectByType(typeof(com.digitalwave.iCare.middletier.HIS.clsCharge));

            long l = objSvc.m_lngPatchDayAccount(PatientChargeArr, DayAccountID);
            objSvc.Dispose();

            return l;
        }
        #endregion

        #region ���淢Ʊ��ӡ����
        /// <summary>
        /// ���淢Ʊ��ӡ����
        /// </summary>
        /// <param name="ChargeItemCatArr">���÷�������VO</param>
        /// <param name="Scope">��Χ: 1 ������� 2 ���﷢Ʊ 3 סԺ���� 4 סԺ��Ʊ</param>
        /// <returns></returns>        
        public long m_lngSaveInvoiceSet(ArrayList ChargeItemCatArr, string Scope)
        {
            com.digitalwave.iCare.middletier.HIS.clsCharge objSvc =
                                                           (com.digitalwave.iCare.middletier.HIS.clsCharge)com.digitalwave.iCare.common.clsObjectGenerator.objCreatorObjectByType(typeof(com.digitalwave.iCare.middletier.HIS.clsCharge));

            long l = objSvc.m_lngSaveInvoiceSet(ChargeItemCatArr, Scope);
            objSvc.Dispose();

            return l;
        }
        #endregion

        #region �տ�Ա�ս�(��Ʊ+����)
        /// <summary>
        /// �տ�Ա�ս�(��Ʊ+����)
        /// </summary>
        /// <param name="EmpID"></param>
        /// <param name="RecDate"></param>
        /// <param name="RemarkInfo"></param>
        /// <param name="RecType">0 ȫ�� 1 ��Ʊ 2 ����</param>
        /// <returns></returns>        
        public long m_lngDayReckoningUnion(string EmpID, string RecDate, string RemarkInfo, int RecType)
        {
            com.digitalwave.iCare.middletier.HIS.clsCharge objSvc =
                                                           (com.digitalwave.iCare.middletier.HIS.clsCharge)com.digitalwave.iCare.common.clsObjectGenerator.objCreatorObjectByType(typeof(com.digitalwave.iCare.middletier.HIS.clsCharge));

            long l = objSvc.m_lngDayReckoningUnion(EmpID, RecDate, RemarkInfo, RecType);
            objSvc.Dispose();

            return l;
        }
        #endregion

        #region �տ�Ա�ս�(��Ʊ)
        /// <summary>
        /// �տ�Ա�ս�(��Ʊ)
        /// </summary>
        /// <param name="EmpID"></param>
        /// <param name="RecDate"></param>
        /// <param name="RemarkInfo"></param>
        /// <returns></returns>        
        public long m_lngDayReckoning(string EmpID, string RecDate, string RemarkInfo)
        {
            com.digitalwave.iCare.middletier.HIS.clsCharge objSvc =
                                                           (com.digitalwave.iCare.middletier.HIS.clsCharge)com.digitalwave.iCare.common.clsObjectGenerator.objCreatorObjectByType(typeof(com.digitalwave.iCare.middletier.HIS.clsCharge));

            long l = objSvc.m_lngDayReckoning(EmpID, RecDate, RemarkInfo);
            objSvc.Dispose();

            return l;
        }
        #endregion

        #region �տ�Ա�ս�(����)
        /// <summary>
        /// �տ�Ա�ս�(����)
        /// </summary>
        /// <param name="EmpID">�տ�ԱID</param>
        /// <param name="RecDate"></param>  
        /// <param name="RemarkInfo"></param>
        /// <returns></returns>        
        public long m_lngDayReckoningPre(string EmpID, string RecDate, string RemarkInfo)
        {
            com.digitalwave.iCare.middletier.HIS.clsCharge objSvc =
                                                           (com.digitalwave.iCare.middletier.HIS.clsCharge)com.digitalwave.iCare.common.clsObjectGenerator.objCreatorObjectByType(typeof(com.digitalwave.iCare.middletier.HIS.clsCharge));

            long l = objSvc.m_lngDayReckoningPre(EmpID, RecDate, RemarkInfo);
            objSvc.Dispose();

            return l;
        }
        #endregion

        #region ��ȡ�տ�Ա�ս�ʱ���б�
        /// <summary>
        /// ��ȡ�տ�Ա�ս�ʱ���б�
        /// </summary>
        /// <param name="EmpID"></param>
        /// <param name="BeginDate"></param>
        /// <param name="EndDate"></param>
        /// <param name="dt"></param>
        /// <returns></returns>        
        public long m_lngGetDayReckoningTime(string EmpID, string BeginDate, string EndDate, out DataTable dt)
        {
            com.digitalwave.iCare.middletier.HIS.clsCharge objSvc =
                                                   (com.digitalwave.iCare.middletier.HIS.clsCharge)com.digitalwave.iCare.common.clsObjectGenerator.objCreatorObjectByType(typeof(com.digitalwave.iCare.middletier.HIS.clsCharge));

            long l = objSvc.m_lngGetDayReckoningTime(EmpID, BeginDate, EndDate, out dt);
            objSvc.Dispose();

            return l;
        }
        #endregion

        #region (ҽ��)����סԺ�շ����ݵ�ҽ��ǰ�û�
        /// <summary>
        /// (ҽ��)����סԺ�շ����ݵ�ҽ��ǰ�û�
        /// </summary>
        /// <param name="DSN"></param>
        /// <param name="objYBArr"></param>
        /// <returns></returns>
        public long m_lngSendybdata(string DSN, ArrayList objYBArr)
        {
            //com.digitalwave.iCare.middletier.HIS.clsZyYB objSvc =
            //                                                   (com.digitalwave.iCare.middletier.HIS.clsZyYB)com.digitalwave.iCare.common.clsObjectGenerator.objCreatorObjectByType(typeof(com.digitalwave.iCare.middletier.HIS.clsZyYB));

            clsZyYB objSvc = new clsZyYB();

            long l = objSvc.m_lngSendybdata(DSN, objYBArr);

            return l;
        }

        /// <summary>
        /// (ҽ��)����סԺ�շ����ݵ�ҽ��ǰ�û�
        /// </summary>
        /// <param name="DSN"></param>
        /// <param name="objYBArr"></param>
        /// <returns></returns>
        public long m_lngSendybdata(string DSN, DataTable dt)
        {
            //com.digitalwave.iCare.middletier.HIS.clsZyYB objSvc =
            //                                             (com.digitalwave.iCare.middletier.HIS.clsZyYB)com.digitalwave.iCare.common.clsObjectGenerator.objCreatorObjectByType(typeof(com.digitalwave.iCare.middletier.HIS.clsZyYB));

            clsZyYB objSvc = new clsZyYB();

            long l = objSvc.m_lngSendybdata(DSN, dt);

            return l;
        }
        #endregion

        #region (ҽ��)��ѯ�����շ���Ŀ�Ƿ�ɹ�
        /// <summary>
        /// (ҽ��)��ѯ�����շ���Ŀ�Ƿ�ɹ�
        /// </summary>
        /// <param name="DSN"></param>
        /// <param name="Hospcode"></param>
        /// <param name="ZYNo"></param>
        /// <param name="ZYSno"></param>
        /// <returns></returns>
        public bool m_blnCheckSendRes(string DSN, string Hospcode, string ZYNo, string ZYSno)
        {
            //com.digitalwave.iCare.middletier.HIS.clsZyYB objSvc =
            //                                                   (com.digitalwave.iCare.middletier.HIS.clsZyYB)com.digitalwave.iCare.common.clsObjectGenerator.objCreatorObjectByType(typeof(com.digitalwave.iCare.middletier.HIS.clsZyYB));

            clsZyYB objSvc = new clsZyYB();

            bool b = objSvc.m_blnCheckSendRes(DSN, Hospcode, ZYNo, ZYSno);

            return b;
        }
        #endregion

        #region (ҽ��)����ʱHIS����ʧ�ܣ��ֹ�ɾ����������
        /// <summary>
        /// (ҽ��)����ʱHIS����ʧ�ܣ��ֹ�ɾ����������
        /// </summary>
        /// <param name="billno"></param>
        /// <returns></returns>
        public long m_lngDelybdata(string DSN, string ZYNo, string ZYSno)
        {
            //com.digitalwave.iCare.middletier.HIS.clsZyYB objSvc =
            //                                              (com.digitalwave.iCare.middletier.HIS.clsZyYB)com.digitalwave.iCare.common.clsObjectGenerator.objCreatorObjectByType(typeof(com.digitalwave.iCare.middletier.HIS.clsZyYB));

            clsZyYB objSvc = new clsZyYB();

            long l = objSvc.m_lngDelybdata(DSN, ZYNo, ZYSno);

            return l;
        }
        #endregion

        #region (ҽ��)��ȡҽ��������ϸ
        /// <summary>
        /// (ҽ��)��ȡҽ��������ϸ
        /// </summary>
        /// <param name="DSN"></param>        
        /// <param name="Hospcode"></param>        
        /// <param name="ZYNo"></param>
        /// <param name="ZYSno"></param>
        /// <param name="YbType">1 ��ͨ 2 ����Ա</param>
        /// <returns></returns>      
        public long m_lngGetybjsmx(string DSN, string Hospcode, string ZYNo, string ZYSno, out DataTable dtRecord, out int YbType)
        {
            //com.digitalwave.iCare.middletier.HIS.clsZyYB objSvc =
            //                                              (com.digitalwave.iCare.middletier.HIS.clsZyYB)com.digitalwave.iCare.common.clsObjectGenerator.objCreatorObjectByType(typeof(com.digitalwave.iCare.middletier.HIS.clsZyYB));

            clsZyYB objSvc = new clsZyYB();

            long l = objSvc.m_lngGetybjsmx(DSN, Hospcode, ZYNo, ZYSno, out dtRecord, out YbType);

            return l;
        }
        #endregion

        #region (ҽ������)��������
        /// <summary>
        /// (ҽ������)��������
        /// </summary>
        /// <param name="HospCode"></param>
        /// <param name="RegID"></param>
        /// <param name="Mode">1 ģʽһ��ȫ��δ����Ŀ 2 ģʽ����ָ����Ŀ</param>
        /// <returns></returns>        
        public long m_lngBudgetSendData(string HospCode, string RegID, int Mode)
        {
            com.digitalwave.iCare.middletier.HIS.clsCharge objSvc =
                                                           (com.digitalwave.iCare.middletier.HIS.clsCharge)com.digitalwave.iCare.common.clsObjectGenerator.objCreatorObjectByType(typeof(com.digitalwave.iCare.middletier.HIS.clsCharge));

            long l = objSvc.m_lngBudgetSendData(HospCode, RegID, Mode);
            objSvc.Dispose();

            return l;
        }
        #endregion

        #region (ҽ������)��������
        /// <summary>
        /// (ҽ������)��������
        /// </summary>
        /// <param name="RegID"></param>
        /// <param name="dtMain"></param>
        /// <param name="dtDet"></param>
        /// <returns></returns>        
        public long m_lngBudgetGetData(string RegID, out DataTable dtMain, out DataTable dtDet)
        {
            com.digitalwave.iCare.middletier.HIS.clsCharge objSvc =
                                                           (com.digitalwave.iCare.middletier.HIS.clsCharge)com.digitalwave.iCare.common.clsObjectGenerator.objCreatorObjectByType(typeof(com.digitalwave.iCare.middletier.HIS.clsCharge));

            long l = objSvc.m_lngBudgetGetData(RegID, out dtMain, out dtDet);
            objSvc.Dispose();

            return l;
        }
        #endregion

        #region (ҽ��)����ҽ��ǰ�û�����
        /// <summary>
        /// (ҽ��)����ҽ��ǰ�û�����
        /// </summary>
        /// <param name="DSN"></param>
        /// <param name="Hospcode"></param>
        /// <param name="ZYNo"></param>
        /// <param name="ZYSno"></param>
        /// <param name="dt"></param>
        /// <returns></returns>
        public long m_lngDownloadYBData(string DSN, string Hospcode, string ZYNo, string ZYSno, out DataTable dt)
        {
            //com.digitalwave.iCare.middletier.HIS.clsZyYB objSvc =
            //                                             (com.digitalwave.iCare.middletier.HIS.clsZyYB)com.digitalwave.iCare.common.clsObjectGenerator.objCreatorObjectByType(typeof(com.digitalwave.iCare.middletier.HIS.clsZyYB));

            clsZyYB objSvc = new clsZyYB();

            long l = objSvc.m_lngDownloadYBData(DSN, Hospcode, ZYNo, ZYSno, out dt);

            return l;
        }
        #endregion

        #region (ҽ��)����ҽ��ǰ�û�����->���ɵ�����
        /// <summary>
        /// (ҽ��)����ҽ��ǰ�û�����->���ɵ�����
        /// </summary>
        /// <param name="dt"></param>
        /// <returns></returns>        
        public long m_lngDownloadYBData(DataTable dt)
        {
            com.digitalwave.iCare.middletier.HIS.clsCharge objSvc =
                                                           (com.digitalwave.iCare.middletier.HIS.clsCharge)com.digitalwave.iCare.common.clsObjectGenerator.objCreatorObjectByType(typeof(com.digitalwave.iCare.middletier.HIS.clsCharge));

            long l = objSvc.m_lngDownloadYBData(dt);
            objSvc.Dispose();

            return l;
        }
        #endregion

        #region (ҽ��)ɾ��������ҽ��ǰ�û�����
        /// <summary>
        /// (ҽ��)ɾ��������ҽ��ǰ�û�����
        /// </summary>
        /// <param name="Zyh"></param>
        /// <param name="Zycs"></param>
        /// <returns></returns>        
        public long m_lngDelDownloadYBData(string Zyh, int Zycs)
        {
            com.digitalwave.iCare.middletier.HIS.clsCharge objSvc =
                                                           (com.digitalwave.iCare.middletier.HIS.clsCharge)com.digitalwave.iCare.common.clsObjectGenerator.objCreatorObjectByType(typeof(com.digitalwave.iCare.middletier.HIS.clsCharge));

            long l = objSvc.m_lngDelDownloadYBData(Zyh, Zycs);
            objSvc.Dispose();

            return l;
        }
        #endregion

        #region (ҽ��)��ȡ������ҽ��ǰ�û�����
        /// <summary>
        /// (ҽ��)��ȡ������ҽ��ǰ�û�����
        /// </summary>
        /// <param name="Zyh"></param>
        /// <param name="Zycs"></param>
        /// <param name="dt"></param>
        /// <returns></returns>        
        public long m_lngGetDownloadYBData(string Zyh, int Zycs, out DataTable dt)
        {
            com.digitalwave.iCare.middletier.HIS.clsCharge objSvc =
                                                           (com.digitalwave.iCare.middletier.HIS.clsCharge)com.digitalwave.iCare.common.clsObjectGenerator.objCreatorObjectByType(typeof(com.digitalwave.iCare.middletier.HIS.clsCharge));

            long l = objSvc.m_lngGetDownloadYBData(Zyh, Zycs, out dt);
            objSvc.Dispose();

            return l;
        }
        #endregion
        #region ҽ������
        /// <summary>
        /// ҽ������
        /// </summary>
        /// <param name="HospCode"></param>
        /// <param name="RegID"></param>
        /// <param name="Zyh"></param>
        /// <param name="Zycs"></param>
        /// <param name="TotalMoney"></param>
        /// <param name="InsuredMoney"></param>
        /// <param name="OutErrMsg"></param>
        /// <returns></returns>        
        public long m_lngYBBudget(string HospCode, string RegID, string Zyh, int Zycs, out decimal TotalMoney, out decimal InsuredMoney, out string OutErrMsg)
        {
            //com.digitalwave.iCare.middletier.HIS.clsZyYB objSvc =
            //                                               (com.digitalwave.iCare.middletier.HIS.clsZyYB)com.digitalwave.iCare.common.clsObjectGenerator.objCreatorObjectByType(typeof(com.digitalwave.iCare.middletier.HIS.clsZyYB));                                            
            com.digitalwave.iCare.middletier.HIS.clsZyYBSS objSvc =
                                                           (com.digitalwave.iCare.middletier.HIS.clsZyYBSS)com.digitalwave.iCare.common.clsObjectGenerator.objCreatorObjectByType(typeof(com.digitalwave.iCare.middletier.HIS.clsZyYBSS));
            //clsZyYB objSvc = new clsZyYB();
            long lngRes = objSvc.m_lngYBBudget(HospCode, RegID, Zyh, Zycs, out TotalMoney, out InsuredMoney, out OutErrMsg);
            lngRes = objSvc.m_lngZYSS(HospCode, Zyh, Zycs, out TotalMoney, out InsuredMoney, out OutErrMsg);
            objSvc = null;

            return lngRes;
        }
        #endregion

        #region (��ɽҽ��)����DBF�ļ�
        /// <summary>
        /// (��ɽҽ��)����DBF�ļ�
        /// </summary>
        /// <param name="DSN"></param>
        /// <param name="DbfName"></param>
        /// <param name="objYBArr"></param>
        /// <returns></returns>  
        public long m_lngCreateDBF(string DSN, string DbfName, ArrayList objYBArr)
        {
            com.digitalwave.iCare.middletier.HIS.clsChaShan objSvc = new clsChaShan();
            //(com.digitalwave.iCare.middletier.HIS.clsChaShan)com.digitalwave.iCare.common.clsObjectGenerator.objCreatorObjectByType(typeof(com.digitalwave.iCare.middletier.HIS.clsChaShan));

            long l = objSvc.m_lngCreateDbf(DSN, DbfName, objYBArr);

            return l;
        }
        #endregion

        #region (ҽ��)��ȡ���
        /// <summary>
        /// (ҽ��)��ȡ���
        /// </summary>
        /// <param name="DSN"></param>
        /// <param name="DbfName"></param>
        /// <param name="dt"></param>
        /// <returns></returns>
        public long m_lngGetResult(string DSN, string DbfName, out DataTable dtRecord)
        {
            com.digitalwave.iCare.middletier.HIS.clsChaShan objSvc = new clsChaShan();
            //(com.digitalwave.iCare.middletier.HIS.clsChaShan)com.digitalwave.iCare.common.clsObjectGenerator.objCreatorObjectByType(typeof(com.digitalwave.iCare.middletier.HIS.clsChaShan));

            long l = objSvc.m_lngGetResult(DSN, DbfName, out dtRecord);

            return l;
        }
        #endregion

        #region ����������Ŀ
        /// <summary>
        /// ����������Ŀ
        /// </summary>
        /// <param name="ID"></param>        
        /// <param name="dt"></param>
        /// <returns></returns>        
        public long m_lngFindOrderByID(string ID, out DataTable dt, bool isChildPrice)
        {
            com.digitalwave.iCare.middletier.HIS.clsCommonQuery objSvc =
                                                            (com.digitalwave.iCare.middletier.HIS.clsCommonQuery)com.digitalwave.iCare.common.clsObjectGenerator.objCreatorObjectByType(typeof(com.digitalwave.iCare.middletier.HIS.clsCommonQuery));

            long l = objSvc.m_lngFindOrderByID(ID, out dt, isChildPrice);
            objSvc.Dispose();

            return l;
        }
        #endregion

        #region ����������Ŀ��ȡ�շ���Ŀ
        /// <summary>
        /// ����������Ŀ��ȡ�շ���Ŀ
        /// </summary>
        /// <param name="OrderID"></param>
        /// <param name="PayTypeID"></param>
        /// <param name="dt"></param>
        /// <returns></returns>        
        public long m_lngGetChargeItemByOrderID(string OrderID, string PayTypeID, out DataTable dt, bool isChildPrice)
        {
            com.digitalwave.iCare.middletier.HIS.clsCommonQuery objSvc =
                                                                (com.digitalwave.iCare.middletier.HIS.clsCommonQuery)com.digitalwave.iCare.common.clsObjectGenerator.objCreatorObjectByType(typeof(com.digitalwave.iCare.middletier.HIS.clsCommonQuery));

            long l = objSvc.m_lngGetChargeItemByOrderID(OrderID, PayTypeID, out dt, isChildPrice);
            objSvc.Dispose();

            return l;
        }
        #endregion

        #region �ж�������Ŀ(���)�Ƿ���������
        /// <summary>
        /// �ж�������Ŀ(���)�Ƿ���������
        /// </summary>
        /// <param name="OrderID">������ĿID</param>
        /// <param name="InvoCatArr">��Ʊ��������</param>
        /// <param name="SysType">ϵͳ 1 ���� 2 סԺ</param>
        /// <param name="ItemNums">��Ŀ����</param>
        /// <returns></returns>        
        public bool m_blnCheckOrderDiscount(string OrderID, ArrayList InvoCatArr, int SysType, int ItemNums)
        {
            com.digitalwave.iCare.middletier.HIS.clsCommonQuery objSvc =
                                                                (com.digitalwave.iCare.middletier.HIS.clsCommonQuery)com.digitalwave.iCare.common.clsObjectGenerator.objCreatorObjectByType(typeof(com.digitalwave.iCare.middletier.HIS.clsCommonQuery));

            bool b = objSvc.m_blnCheckOrderDiscount(OrderID, InvoCatArr, SysType, ItemNums);
            objSvc.Dispose();

            return b;
        }
        #endregion

        #region ��ȡ�����ʡ�ֱ�շ���(������Ŀ)������¼
        /// <summary>
        /// ��ȡ�����ʡ�ֱ�շ���(������Ŀ)������¼
        /// </summary>
        /// <param name="OrderID"></param>
        /// <param name="dt"></param>
        /// <returns></returns>        
        public long m_lngGetOrderDic(string OrderID, out DataTable dt)
        {
            com.digitalwave.iCare.middletier.HIS.clsCharge objSvc =
                                                           (com.digitalwave.iCare.middletier.HIS.clsCharge)com.digitalwave.iCare.common.clsObjectGenerator.objCreatorObjectByType(typeof(com.digitalwave.iCare.middletier.HIS.clsCharge));

            long l = objSvc.m_lngGetOrderDic(OrderID, out dt);
            objSvc.Dispose();

            return l;
        }
        #endregion

        #region (ҽ��)����ҽ��ͳ�����
        /// <summary>
        /// (ҽ��)����ҽ��ͳ�����
        /// </summary>
        /// <param name="RegID"></param>
        /// <param name="InsuredSum"></param>
        /// <returns></returns>        
        public long m_lngUpdateInsuredSum(string RegID, decimal InsuredSum)
        {
            com.digitalwave.iCare.middletier.HIS.clsCharge objSvc =
                                                 (com.digitalwave.iCare.middletier.HIS.clsCharge)com.digitalwave.iCare.common.clsObjectGenerator.objCreatorObjectByType(typeof(com.digitalwave.iCare.middletier.HIS.clsCharge));

            long l = objSvc.m_lngUpdateInsuredSum(RegID, InsuredSum);
            objSvc.Dispose();

            return l;
        }
        #endregion

        #region ��Ժ�����������ڳ���λ
        /// <summary>
        /// ��Ժ�����������ڳ���λ
        /// </summary>
        /// <param name="RegID"></param>
        /// <returns></returns>        
        public long m_lngClearBed(string RegID)
        {
            com.digitalwave.iCare.middletier.HIS.clsCharge objSvc =
                                                 (com.digitalwave.iCare.middletier.HIS.clsCharge)com.digitalwave.iCare.common.clsObjectGenerator.objCreatorObjectByType(typeof(com.digitalwave.iCare.middletier.HIS.clsCharge));

            long l = objSvc.m_lngClearBed(RegID);
            objSvc.Dispose();

            return l;
        }
        #endregion

        #region ��¼��ǰ�շ�Աʹ��֮��Ʊ��
        /// <summary>
        /// ��¼��ǰ�շ�Աʹ��֮��Ʊ��
        /// </summary>
        /// <param name="OperID"></param>
        /// <param name="InvoNo"></param>
        /// <param name="Type">���ͣ� 1 סԺ��Ʊ 2 Ѻ�� 3 ���﷢Ʊ</param>
        /// <returns></returns>        
        public long m_lngRegOperInvoNO(string OperID, string InvoNo, int Type)
        {
            com.digitalwave.iCare.middletier.HIS.clsCharge objSvc =
                                                           (com.digitalwave.iCare.middletier.HIS.clsCharge)com.digitalwave.iCare.common.clsObjectGenerator.objCreatorObjectByType(typeof(com.digitalwave.iCare.middletier.HIS.clsCharge));

            long l = objSvc.m_lngRegOperInvoNO(OperID, InvoNo, Type);
            objSvc.Dispose();

            return l;
        }
        #endregion

        #region ��ȡ��ǰ�շ�Աʹ��֮��Ʊ��
        /// <summary>
        /// ��ȡ��ǰ�շ�Աʹ��֮��Ʊ��
        /// </summary>
        /// <param name="OperID"></param>
        /// <param name="Type">���ͣ� 1 סԺ��Ʊ 2 Ѻ�� 3 ���﷢Ʊ</param>
        /// <param name="InvoNo"></param>
        /// <returns></returns>        
        public long m_lngGetOperInvoNO(string OperID, int Type, out string InvoNo)
        {
            com.digitalwave.iCare.middletier.HIS.clsCharge objSvc =
                                                           (com.digitalwave.iCare.middletier.HIS.clsCharge)com.digitalwave.iCare.common.clsObjectGenerator.objCreatorObjectByType(typeof(com.digitalwave.iCare.middletier.HIS.clsCharge));

            long l = objSvc.m_lngGetOperInvoNO(OperID, Type, out InvoNo);
            objSvc.Dispose();

            return l;
        }
        #endregion

        #region ���Ӥ����
        /// <summary>
        /// ���Ӥ����
        /// </summary>
        /// <param name="Zyh"></param>
        /// <param name="dt"></param>
        /// <returns></returns>        
        public long m_lngCheckBaby(string Zyh, out DataTable dt)
        {
            com.digitalwave.iCare.middletier.HIS.clsCommonQuery objSvc =
                                                                (com.digitalwave.iCare.middletier.HIS.clsCommonQuery)com.digitalwave.iCare.common.clsObjectGenerator.objCreatorObjectByType(typeof(com.digitalwave.iCare.middletier.HIS.clsCommonQuery));

            long l = objSvc.m_lngCheckBaby(Zyh, out dt);
            objSvc.Dispose();

            return l;
        }
        #endregion

        #region �������˷�
        /// <summary>
        /// �������˷�
        /// </summary>
        /// <param name="ChargeIDArr"></param>
        /// <param name="EmpID"></param>
        /// <returns></returns>        
        public long m_lngPatchRefundment(ArrayList ChargeIDArr, string EmpID)
        {
            com.digitalwave.iCare.middletier.HIS.clsCharge objSvc =
                                                           (com.digitalwave.iCare.middletier.HIS.clsCharge)com.digitalwave.iCare.common.clsObjectGenerator.objCreatorObjectByType(typeof(com.digitalwave.iCare.middletier.HIS.clsCharge));

            long l = objSvc.m_lngPatchRefundment(ChargeIDArr, EmpID);
            objSvc.Dispose();

            return l;
        }
        #endregion

        #region �޸ı�ע��Ϣ
        /// <summary>
        /// �޸ı�ע��Ϣ
        /// </summary>
        /// <param name="EmpID"></param>
        /// <param name="RecDate"></param>
        /// <param name="RemarkInfo"></param>
        /// <returns></returns>        
        public long m_lngUpdateDayRecRemark(string EmpID, string RecDate, string RemarkInfo)
        {
            com.digitalwave.iCare.middletier.HIS.clsCharge objSvc =
                                                           (com.digitalwave.iCare.middletier.HIS.clsCharge)com.digitalwave.iCare.common.clsObjectGenerator.objCreatorObjectByType(typeof(com.digitalwave.iCare.middletier.HIS.clsCharge));

            long l = objSvc.m_lngUpdateDayRecRemark(EmpID, RecDate, RemarkInfo);
            objSvc.Dispose();

            return l;
        }
        #endregion

        #region ��ȡ��ͬ�ѱ�ķ�����ϸ
        /// <summary>
        /// ��ȡ��ͬ�ѱ�ķ�����ϸ
        /// </summary>
        /// <param name="RegID"></param>
        /// <param name="PayTypeID"></param>
        /// <param name="dt"></param>
        /// <returns></returns>        
        public long m_lngGetPatientFeeDetByPayType(string RegID, string PayTypeID, out DataTable dt)
        {
            com.digitalwave.iCare.middletier.HIS.clsCharge objSvc =
                                                           (com.digitalwave.iCare.middletier.HIS.clsCharge)com.digitalwave.iCare.common.clsObjectGenerator.objCreatorObjectByType(typeof(com.digitalwave.iCare.middletier.HIS.clsCharge));

            long l = objSvc.m_lngGetPatientFeeDetByPayType(RegID, PayTypeID, out dt);
            objSvc.Dispose();

            return l;
        }
        #endregion

        #region ������ϸ��Ӧ֮������Ŀ
        /// <summary>
        /// ������ϸ��Ӧ֮������Ŀ
        /// </summary>
        /// <param name="RegID"></param>
        /// <param name="ActiveType">��Ч����{1=����;2=������;3=ȷ�ϼ���;4=ȷ���շ�;5=ֱ���շ�;888=����״̬����;999=ȫ��}</param>
        /// <param name="Pstatus"></param>
        /// <param name="AreaID"></param>
        /// <param name="BeginDate"></param>
        /// <param name="EndDate"></param>
        /// <param name="dt"></param>
        /// <returns></returns>
        public long m_lngGetFeeDiagItem(string RegID, int ActiveType, string Pstatus, string AreaID, string BeginDate, string EndDate, out DataTable dt)
        {
            com.digitalwave.iCare.middletier.HIS.clsCharge objSvc =
                                                           (com.digitalwave.iCare.middletier.HIS.clsCharge)com.digitalwave.iCare.common.clsObjectGenerator.objCreatorObjectByType(typeof(com.digitalwave.iCare.middletier.HIS.clsCharge));

            long l = objSvc.m_lngGetFeeDiagItem(RegID, ActiveType, Pstatus, AreaID, BeginDate, EndDate, out dt);
            objSvc.Dispose();

            return l;
        }
        #endregion

        #region ���ݷ�����ϸID���ҷ�����Ϣ
        /// <summary>
        /// ���ݷ�����ϸID���ҷ�����Ϣ
        /// </summary>
        /// <param name="DiagArr"></param>
        /// <param name="dtNormal"></param>
        /// <param name="dtRefundment"></param>
        /// <returns></returns>        
        public long m_lngGetFeeItemByActiveType(ArrayList DiagArr, out DataTable dtNormal, out DataTable dtRefundment)
        {
            com.digitalwave.iCare.middletier.HIS.clsCharge objSvc =
                                                           (com.digitalwave.iCare.middletier.HIS.clsCharge)com.digitalwave.iCare.common.clsObjectGenerator.objCreatorObjectByType(typeof(com.digitalwave.iCare.middletier.HIS.clsCharge));

            long l = objSvc.m_lngGetFeeItemByActiveType(DiagArr, out dtNormal, out dtRefundment);
            objSvc.Dispose();

            return l;
        }
        #endregion

        #region ���������ͻ�ȡ���˷��÷���
        /// <summary>
        /// ���������ͻ�ȡ���˷��÷���
        /// </summary>
        /// <param name="RegID"></param>
        /// <param name="DeptClass">1 ִ�п��� 2 �������� 3 ���ڲ���</param>
        /// <param name="Status">0 δ���ʽ��� 1 �Ѵ��ʽ���</param>
        /// <param name="dt"></param>
        /// <returns></returns>        
        public long m_lngGetFeeCatByDeptClass(string RegID, int DeptClass, int Status, out DataTable dt)
        {
            com.digitalwave.iCare.middletier.HIS.clsCharge objSvc =
                                                           (com.digitalwave.iCare.middletier.HIS.clsCharge)com.digitalwave.iCare.common.clsObjectGenerator.objCreatorObjectByType(typeof(com.digitalwave.iCare.middletier.HIS.clsCharge));

            long l = objSvc.m_lngGetFeeCatByDeptClass(RegID, DeptClass, Status, out dt);
            objSvc.Dispose();

            return l;
        }
        #endregion

        #region ���������ͻ�ȡ���˷��÷���ĸӤ�ϲ�����ʹ�� by yibing.zheng 09-07-04

        /// <summary>
        /// ���������ͻ�ȡ���˷��÷���ĸӤ�ϲ�����ʹ��
        /// </summary>
        /// <param name="RegID"></param>
        /// <param name="DeptClass">1 ִ�п��� 2 �������� 3 ���ڲ���</param>
        /// <param name="Status">0 δ���ʽ��� 1 �Ѵ��ʽ���</param>
        /// <param name="dt"></param>
        /// <returns></returns>

        public long m_lngGetFeeCatByDeptClassForMortherBaby(string RegID, int DeptClass, int Status, out DataTable dt)
        {
            com.digitalwave.iCare.middletier.HIS.clsCharge objSvc =
                                                                       (com.digitalwave.iCare.middletier.HIS.clsCharge)com.digitalwave.iCare.common.clsObjectGenerator.objCreatorObjectByType(typeof(com.digitalwave.iCare.middletier.HIS.clsCharge));

            long l = objSvc.m_lngGetFeeCatByDeptClassForMortherBaby(RegID, DeptClass, Status, out dt);
            objSvc.Dispose();

            return l;
        }
        #endregion

        #region ���ʽ���
        /// <summary>
        /// ���ʽ���
        /// </summary>
        /// <param name="Charge_VO"></param>
        /// <param name="ChargeCatArr"></param>
        /// <param name="FactTotalMoney">ʵ��δ�ᡢδ���ܽ��</param>
        /// <param name="FactPreMoney">ʵ�ʷ�̯�ܽ��</param>
        /// <param name="DiffValDeptID">��ֵ�����ID</param>
        /// <param name="DiffValCatID">��ֵ��������ID</param>
        /// <param name="IsHavePrepayMoney">�Ƿ���Ԥ���� (true �� false ��)</param>
        /// <param name="ChargeNo"></param>
        /// <returns></returns>        
        public long m_lngBadCharge(clsBihCharge_VO Charge_VO, ArrayList ChargeCatArr, clsBihInvoice_VO Invoice_VO, ArrayList InvoCatArr, ArrayList PaymentArr, decimal FactTotalMoney, decimal FactPreMoney, string DiffValDeptID, string DiffValCatID, bool IsHavePrepayMoney, out string ChargeNo)
        {
            com.digitalwave.iCare.middletier.HIS.clsCharge objSvc =
                                                           (com.digitalwave.iCare.middletier.HIS.clsCharge)com.digitalwave.iCare.common.clsObjectGenerator.objCreatorObjectByType(typeof(com.digitalwave.iCare.middletier.HIS.clsCharge));

            long l = objSvc.m_lngBadCharge(Charge_VO, ChargeCatArr, Invoice_VO, InvoCatArr, PaymentArr, FactTotalMoney, FactPreMoney, DiffValDeptID, DiffValCatID, IsHavePrepayMoney, out ChargeNo);
            objSvc.Dispose();

            return l;
        }
        #endregion

        #region ��ȡ���ʲ���δ�����
        /// <summary>
        /// ��ȡ���ʲ���δ�����
        /// </summary>
        /// <param name="RegID"></param>
        /// <param name="dt"></param>
        /// <returns></returns>        
        public long m_lngGetBadChargeFeeInfo(string RegID, out DataTable dt)
        {
            com.digitalwave.iCare.middletier.HIS.clsCharge objSvc =
                                                           (com.digitalwave.iCare.middletier.HIS.clsCharge)com.digitalwave.iCare.common.clsObjectGenerator.objCreatorObjectByType(typeof(com.digitalwave.iCare.middletier.HIS.clsCharge));

            long l = objSvc.m_lngGetBadChargeFeeInfo(RegID, out dt);
            objSvc.Dispose();

            return l;
        }

        /// <summary>
        /// ��ȡ���ʲ���δ�����(ĸӤ�ϲ��������)
        /// </summary>
        /// <param name="RegID">����ID</param>
        /// <param name="dt"></param>
        /// <returns></returns>
        public long m_lngGetBadChargeFeeInfoMotherBaby(string RegID, out DataTable dt)
        {
            com.digitalwave.iCare.middletier.HIS.clsCharge objSvc =
                                                          (com.digitalwave.iCare.middletier.HIS.clsCharge)com.digitalwave.iCare.common.clsObjectGenerator.objCreatorObjectByType(typeof(com.digitalwave.iCare.middletier.HIS.clsCharge));

            long lngRes = objSvc.m_lngGetBadChargeFeeInfoMotherBaby(RegID, out dt);
            objSvc.Dispose();
            objSvc = null;
            return lngRes;
        }
        #endregion

        #region ����
        /// <summary>
        /// ����
        /// </summary>
        /// <param name="Charge_VO"></param>
        /// <param name="ChargeNo"></param>
        /// <returns></returns>        
        public long m_lngReckoning(clsBihCharge_VO Charge_VO, out string ChargeNo)
        {
            com.digitalwave.iCare.middletier.HIS.clsCharge objSvc =
                                                           (com.digitalwave.iCare.middletier.HIS.clsCharge)com.digitalwave.iCare.common.clsObjectGenerator.objCreatorObjectByType(typeof(com.digitalwave.iCare.middletier.HIS.clsCharge));

            long l = objSvc.m_lngReckoning(Charge_VO, out ChargeNo);
            objSvc.Dispose();

            return l;
        }
        #endregion

        #region ��ȡ�������д���ID
        /// <summary>
        /// ��ȡ�������д���ID
        /// </summary>
        /// <param name="BeginDate"></param>
        /// <param name="EndDate"></param>
        /// <param name="dt"></param>
        /// <returns></returns>        
        public long m_lngMzGetAcctRecipeID(string BeginDate, string EndDate, out DataTable dt)
        {
            com.digitalwave.iCare.middletier.HIS.clsCharge objSvc =
                                                           (com.digitalwave.iCare.middletier.HIS.clsCharge)com.digitalwave.iCare.common.clsObjectGenerator.objCreatorObjectByType(typeof(com.digitalwave.iCare.middletier.HIS.clsCharge));

            long l = objSvc.m_lngMzGetAcctRecipeID(BeginDate, EndDate, out dt);
            objSvc.Dispose();

            return l;
        }
        #endregion

        #region �������շѴ���ID��ȡ�������
        /// <summary>
        /// �������շѴ���ID��ȡ�������
        /// </summary>
        /// <param name="RecipeID"></param>
        /// <param name="dt"></param>
        /// <returns></returns>        
        public long m_lngMzGetRecipeCat(string RecipeID, out DataTable dt)
        {
            com.digitalwave.iCare.middletier.HIS.clsCharge objSvc =
                                                           (com.digitalwave.iCare.middletier.HIS.clsCharge)com.digitalwave.iCare.common.clsObjectGenerator.objCreatorObjectByType(typeof(com.digitalwave.iCare.middletier.HIS.clsCharge));

            long l = objSvc.m_lngMzGetRecipeCat(RecipeID, out dt);
            objSvc.Dispose();

            return l;
        }
        #endregion

        #region ����SEQID��ȡ�������
        /// <summary>
        /// ����SEQID��ȡ�������
        /// </summary>
        /// <param name="SeqID"></param>
        /// <param name="dt"></param>
        /// <returns></returns>        
        public long m_lngMzGetChargeCat(string SeqID, out DataTable dt)
        {
            com.digitalwave.iCare.middletier.HIS.clsCharge objSvc =
                                                           (com.digitalwave.iCare.middletier.HIS.clsCharge)com.digitalwave.iCare.common.clsObjectGenerator.objCreatorObjectByType(typeof(com.digitalwave.iCare.middletier.HIS.clsCharge));

            long l = objSvc.m_lngMzGetChargeCat(SeqID, out dt);
            objSvc.Dispose();

            return l;
        }
        #endregion

        #region ����SEQID��CatID���º������
        /// <summary>
        /// ����SEQID��CatID���º������
        /// </summary>
        /// <param name="SeqID"></param>
        /// <param name="CatIDArr"></param>
        /// <param name="CatSumArr"></param>
        /// <returns></returns>        
        public long m_lngMzUpdateChargeCat(string SeqID, ArrayList CatIDArr, ArrayList CatSumArr, string PStatus)
        {
            com.digitalwave.iCare.middletier.HIS.clsCharge objSvc =
                                                           (com.digitalwave.iCare.middletier.HIS.clsCharge)com.digitalwave.iCare.common.clsObjectGenerator.objCreatorObjectByType(typeof(com.digitalwave.iCare.middletier.HIS.clsCharge));

            long l = objSvc.m_lngMzUpdateChargeCat(SeqID, CatIDArr, CatSumArr, PStatus);
            objSvc.Dispose();

            return l;
        }
        #endregion

        #region ���ݴ���ID��ȡSEQID�б�
        /// <summary>
        /// ���ݴ���ID��ȡSEQID�б�
        /// </summary>
        /// <param name="RecipeID"></param>
        /// <param name="dt"></param>
        /// <returns></returns>
        public long m_lngMzGetSeqIDList(string RecipeID, out DataTable dt)
        {
            com.digitalwave.iCare.middletier.HIS.clsCharge objSvc =
                                                           (com.digitalwave.iCare.middletier.HIS.clsCharge)com.digitalwave.iCare.common.clsObjectGenerator.objCreatorObjectByType(typeof(com.digitalwave.iCare.middletier.HIS.clsCharge));

            long l = objSvc.m_lngMzGetSeqIDList(RecipeID, out dt);
            objSvc.Dispose();

            return l;
        }
        #endregion

        #region <����>��Ʊ��Ϣ
        /// <summary>
        /// (����)��Ʊ��Ϣ 
        /// </summary>
        /// <param name="ChargeNo"></param>
        /// <param name="dtMain"></param>
        /// <param name="dtDet"></param>
        /// <param name="dtPayMode"></param>
        /// <returns></returns>        
        public long m_lngGetOPInvoiceByChargeNo(string ChargeNo, out DataTable dtMain, out DataTable dtDet, out DataTable dtPayMode)
        {
            com.digitalwave.iCare.middletier.HIS.clsCharge objSvc =
                                                          (com.digitalwave.iCare.middletier.HIS.clsCharge)com.digitalwave.iCare.common.clsObjectGenerator.objCreatorObjectByType(typeof(com.digitalwave.iCare.middletier.HIS.clsCharge));

            long l = objSvc.m_lngGetOPInvoiceByChargeNo(ChargeNo, out dtMain, out dtDet, out dtPayMode);
            objSvc.Dispose();

            return l;
        }

        /// <summary>
        /// ���﷢Ʊ��Ϣ 
        /// </summary>
        /// <param name="InvoNo"></param>
        /// <param name="dtMain"></param>
        /// <param name="dtDet"></param>
        /// <param name="dtPayMode"></param>
        /// <returns></returns> 
        public long m_lngGetOPInvoiceByInvoNo(string InvoNo, out DataTable dtMain, out DataTable dtDet, out DataTable dtPayMode)
        {
            com.digitalwave.iCare.middletier.HIS.clsCharge objSvc =
                                                          (com.digitalwave.iCare.middletier.HIS.clsCharge)com.digitalwave.iCare.common.clsObjectGenerator.objCreatorObjectByType(typeof(com.digitalwave.iCare.middletier.HIS.clsCharge));

            long l = objSvc.m_lngGetOPInvoiceByInvoNo(InvoNo, out dtMain, out dtDet, out dtPayMode);
            objSvc.Dispose();

            return l;
        }

        /// <summary>
        /// ���﷢Ʊ��Ϣ(for ��Ʊ)
        /// </summary>
        /// <param name="mode">ģʽ(������ʶ��) 0-��Ʊ</param>
        /// <param name="InvoNo"></param>
        /// <param name="dtMain"></param>
        /// <param name="dtDet"></param>
        /// <param name="dtPayMode"></param>
        /// <returns></returns>
        public long m_lngGetOPInvoiceByInvoNo(int mode, string InvoNo, out DataTable dtMain, out DataTable dtDet, out DataTable dtPayMode)
        {
            com.digitalwave.iCare.middletier.HIS.clsCharge objSvc =
                                                          (com.digitalwave.iCare.middletier.HIS.clsCharge)com.digitalwave.iCare.common.clsObjectGenerator.objCreatorObjectByType(typeof(com.digitalwave.iCare.middletier.HIS.clsCharge));

            long l = objSvc.m_lngGetOPInvoiceByInvoNo(mode, InvoNo, out dtMain, out dtDet, out dtPayMode);
            return l;
        }
        #endregion

        #region ����̨ɽҽ������
        /// <summary>
        /// ���������ϸ
        /// </summary>
        /// <param name="p_strlsh0"></param>
        /// <param name="p_inpatientid"></param>
        /// <returns></returns>
        public long m_lngInsertRegisterCharge(string p_strlsh0, string p_inpatientid)
        {
            clsZyYB objSvc = (clsZyYB)com.digitalwave.iCare.common.clsObjectGenerator.objCreatorObjectByType(typeof(clsZyYB));
            return objSvc.m_lngInsertRegisterCharge(p_strlsh0, p_inpatientid);
        }
        /// <summary>
        /// ���벡����Ϣ
        /// </summary>
        /// <param name="p_strlsh0"></param>
        /// <param name="p_inpatientid"></param>
        /// <returns></returns>
        public long m_lngInsertRegister(string p_strlsh0, string p_inpatientid)
        {
            clsZyYB objSvc = (clsZyYB)com.digitalwave.iCare.common.clsObjectGenerator.objCreatorObjectByType(typeof(clsZyYB));
            return objSvc.m_lngInsertRegister(p_strlsh0, p_inpatientid);
        }
        /// <summary>
        /// ��ȡҽ��֧���Ľ��
        /// </summary>
        /// <param name="p_strlsh0"></param>
        /// <param name="p_strYBpay"></param>
        /// <returns></returns>
        public long m_lngGetYBpay(string p_strlsh0, out string p_strMedno, out string p_strYBpay)
        {
            clsZyYB objSvc = (clsZyYB)com.digitalwave.iCare.common.clsObjectGenerator.objCreatorObjectByType(typeof(clsZyYB));
            return objSvc.m_lngGetYBpay(p_strlsh0, out p_strMedno, out p_strYBpay);
        }
        /// <summary>
        /// ɾ����HIS�ϴ���Ϣ
        /// </summary>
        /// <param name="p_registerid"></param>
        public long m_lngDelYBInfo(string p_strlsh0)
        {
            clsZyYB objSvc = (clsZyYB)com.digitalwave.iCare.common.clsObjectGenerator.objCreatorObjectByType(typeof(clsZyYB));
            return objSvc.m_lngDelYBInfo(p_strlsh0);
        }
        #endregion

        #region ���Ĳ��˷��ú˶�״̬
        /// <summary>
        /// ���Ĳ��˷��ú˶�״̬
        /// </summary>
        /// <param name="RegisterID"></param>
        /// <param name="CheckStatus"></param>
        public long m_lngUpdatePatientChargeCheckStatus(string RegisterID, string CheckStatus)
        {
            com.digitalwave.iCare.middletier.HIS.clsCharge objSvc =
                                                           (com.digitalwave.iCare.middletier.HIS.clsCharge)com.digitalwave.iCare.common.clsObjectGenerator.objCreatorObjectByType(typeof(com.digitalwave.iCare.middletier.HIS.clsCharge));

            long l = objSvc.m_lngUpdatePatientChargeCheckStatus(RegisterID, CheckStatus);
            objSvc.Dispose();

            return l;
        }
        #endregion


        #region ����Ӥ��δ�����
        /// <summary>
        /// ����Ӥ��δ�����
        /// </summary>
        /// <param name="p_strRegisterId">Ӥ��ID</param>
        /// <param name="p_dtbResult">���ؽ��</param>
        /// <returns></returns>
        public long m_lngCheckBabyNoPayCharge(string p_strRegisterId, out DataTable p_dtbResult)
        {
            com.digitalwave.iCare.middletier.HIS.clsCharge objSvc =
                                                                (com.digitalwave.iCare.middletier.HIS.clsCharge)com.digitalwave.iCare.common.clsObjectGenerator.objCreatorObjectByType(typeof(com.digitalwave.iCare.middletier.HIS.clsCharge));

            long lngRes = objSvc.m_lngCheckBabyNoPayCharge(p_strRegisterId, out p_dtbResult);
            objSvc.Dispose();
            objSvc = null;
            return lngRes;
        }
        #endregion

        #region ����ĸ��ID��ȡӤ����Ϣ

        /// <summary>
        /// ����ĸ��ID��ȡӤ����Ϣ
        /// </summary>
        /// <param name="p_strRegisterId"></param>
        /// <param name="p_dtbBabyInfo"></param>
        /// <returns></returns>
        public long m_lngGetBabyRegisterId(string p_strRegisterId, out DataTable p_dtbBabyInfo)
        {
            com.digitalwave.iCare.middletier.HIS.clsCharge objSvc =
                                                                (com.digitalwave.iCare.middletier.HIS.clsCharge)com.digitalwave.iCare.common.clsObjectGenerator.objCreatorObjectByType(typeof(com.digitalwave.iCare.middletier.HIS.clsCharge));

            long lngRes = objSvc.m_lngGetBabyRegisterId(p_strRegisterId, out p_dtbBabyInfo);
            objSvc.Dispose();
            objSvc = null;
            return lngRes;
        }
        #endregion

        #region ��ȡ�����б�
        /// <summary>
        /// ��ȡ�����б�
        /// </summary>
        /// <param name="dtbResult"></param>
        /// <returns></returns>
        public long m_lngGetDepts(out DataTable dtbResult)
        {
            com.digitalwave.iCare.middletier.HIS.clsCharge objSvc =
                                                           (com.digitalwave.iCare.middletier.HIS.clsCharge)com.digitalwave.iCare.common.clsObjectGenerator.objCreatorObjectByType(typeof(com.digitalwave.iCare.middletier.HIS.clsCharge));
            long l = objSvc.m_lngGetDepts(out dtbResult);
            objSvc.Dispose();
            return l;
        }
        #endregion

        #region ��ɽҽ���ϴ� ��Ӧ֢
        public long m_lngCheckChangeSFLB(Dictionary<string, int> p_gdicItemIDs, out Dictionary<string, string> p_gdicItemIDResult)
        {
            com.digitalwave.iCare.middletier.HIS.clsCommonQuery objSvc =
                                                 (com.digitalwave.iCare.middletier.HIS.clsCommonQuery)com.digitalwave.iCare.common.clsObjectGenerator.objCreatorObjectByType(typeof(com.digitalwave.iCare.middletier.HIS.clsCommonQuery));

            long l = objSvc.m_lngCheckChangeSFLB(p_gdicItemIDs, out p_gdicItemIDResult);
            objSvc.Dispose();

            return l;
        }


        public long m_lngGetSFLB_ForZjwsy(out DataTable dtResult)
        {
            com.digitalwave.iCare.middletier.HIS.clsCommonQuery objSvc =
                                                 (com.digitalwave.iCare.middletier.HIS.clsCommonQuery)com.digitalwave.iCare.common.clsObjectGenerator.objCreatorObjectByType(typeof(com.digitalwave.iCare.middletier.HIS.clsCommonQuery));

            long l = objSvc.m_lngGetSFLB_ForZjwsy(out dtResult);
            objSvc.Dispose();

            return l;
        }

        public long m_lngGetPatientChargeSFLB(List<string> m_glstPChargeID,
                                              out Dictionary<string, string> p_gdicItemIDResult,
                                              out Dictionary<string, decimal> p_gdicPatchAmount,
                                              out Dictionary<string, List<string>> p_gdicPatchList)
        {
            com.digitalwave.iCare.middletier.HIS.clsCommonQuery objSvc =
                                     (com.digitalwave.iCare.middletier.HIS.clsCommonQuery)com.digitalwave.iCare.common.clsObjectGenerator.objCreatorObjectByType(typeof(com.digitalwave.iCare.middletier.HIS.clsCommonQuery));

            long l = objSvc.m_lngGetPatientChargeSFLB(m_glstPChargeID, out p_gdicItemIDResult, out p_gdicPatchAmount, out p_gdicPatchList);
            objSvc.Dispose();

            return l;
        }



        public long m_lngSetChargeSFLB_Zjwsy(List<clsSFLB_log> m_glstSFLB, string p_strEmpID, string p_strEmpName)
        {
            com.digitalwave.iCare.middletier.HIS.clsCharge objSvc =
                                                 (com.digitalwave.iCare.middletier.HIS.clsCharge)com.digitalwave.iCare.common.clsObjectGenerator.objCreatorObjectByType(typeof(com.digitalwave.iCare.middletier.HIS.clsCharge));

            long l = objSvc.m_lngSetChargeSFLB_Zjwsy(m_glstSFLB, p_strEmpID, p_strEmpName);
            objSvc.Dispose();

            return l;
        }


        public long m_lngGetPatientPayTypeSFLBBH(string p_strPayType, out string p_strPayNo)
        {
            com.digitalwave.iCare.middletier.HIS.clsCommonQuery objSvc =
                                                 (com.digitalwave.iCare.middletier.HIS.clsCommonQuery)com.digitalwave.iCare.common.clsObjectGenerator.objCreatorObjectByType(typeof(com.digitalwave.iCare.middletier.HIS.clsCommonQuery));

            long l = objSvc.m_lngGetPatientPayTypeSFLBBH(p_strPayType, out p_strPayNo);
            objSvc.Dispose();

            return l;
        }

        #endregion

        #region ��Ŀ��Ӧ֢
        ///// <summary>
        ///// ��Ŀ��Ӧ֢
        ///// </summary>
        ///// <param name="strRegID"></param>
        ///// <param name="dtResult"></param>
        ///// <returns></returns>
        //public long m_lngGetItemShiying(string strRegID, out DataTable dtResult)
        //{
        //    com.digitalwave.iCare.middletier.HIS.clsCommonQuery objSvc =
        //                                                    (com.digitalwave.iCare.middletier.HIS.clsCommonQuery)com.digitalwave.iCare.common.clsObjectGenerator.objCreatorObjectByType(typeof(com.digitalwave.iCare.middletier.HIS.clsCommonQuery));

        //    long l = objSvc.m_lngGetItemShiying(strRegID, out dtResult);
        //    objSvc.Dispose();

        //    return l;
        //}
        #endregion

        #region ͨ����ˮ�Ų�ѯ�����������Ĳ�����˼�¼
        /// <summary>
        /// ͨ����ˮ�Ų�ѯ�����������Ĳ�����˼�¼
        /// </summary>
        /// <param name="p_strIpno"></param>
        /// <param name="p_dtResult"></param>
        /// <returns></returns>
        public long m_lngQueryOpExtraChargeByRgno(string p_strIpno, out DataTable p_dtResult)
        {
            long lngRes = 0;
            p_dtResult = null;

            #region �м������
            clsCommonQuery objServ = null;
            try
            {
                objServ = (clsCommonQuery)com.digitalwave.iCare.common.clsObjectGenerator.objCreatorObjectByType(typeof(clsCommonQuery));
                lngRes = objServ.m_lngQueryOpExtraChargeByRgno(p_strIpno, out p_dtResult);
            }
            catch (Exception exp)
            {
                Utility.clsLogText objLogger = new Utility.clsLogText();
                objLogger.LogError("�����м�������쳣��" + exp.Message);
            }
            finally
            {
                if (objServ != null)
                {
                    objServ.Dispose();
                    objServ = null;
                }
            }
            #endregion
            return lngRes;
        }
        #endregion

        #region ͨ����ˮ�Ų�ѯ������������Ϣ
        /// <summary>
        /// ͨ����ˮ�Ų�ѯ������������Ϣ
        /// </summary>
        /// <param name="p_strIpno"></param>
        /// <param name="p_dtResult"></param>
        /// <returns></returns>
        public long m_lngQuerySMDetailByRgno(string p_strRgno, out DataTable p_dtResult)
        {
            long lngRes = 0;
            p_dtResult = null;

            #region �м������
            clsCommonQuery objServ = null;
            try
            {
                objServ = (clsCommonQuery)com.digitalwave.iCare.common.clsObjectGenerator.objCreatorObjectByType(typeof(clsCommonQuery));
                lngRes = objServ.m_lngQuerySMDetailByRgno(p_strRgno, out p_dtResult);
            }
            catch (Exception exp)
            {
                Utility.clsLogText objLogger = new Utility.clsLogText();
                objLogger.LogError("�����м�������쳣��" + exp.Message);
            }
            finally
            {
                if (objServ != null)
                {
                    objServ.Dispose();
                    objServ = null;
                }
            }
            #endregion
            return lngRes;
        }
        #endregion

        #region �����������뵥�޸ı�
        /// <summary>
        /// �����������뵥�޸ı�
        /// </summary>
        /// <param name="p_strRgno"></param>
        /// <param name="p_strOpreationName"></param>
        /// <param name="p_strANAName"></param>
        /// <param name="p_strANADate"></param>
        /// <param name="p_strEmployID"></param>
        /// <param name="p_strEmployName"></param>
        /// <returns></returns>
        public long m_lngUpdateRequisitionMR(string p_strRgno, string p_strOpreationName, string p_strANAName, string p_strANADate, string p_strEmployID, string p_strEmployName)
        {
            long lngRes = 0;

            #region �м������
            clsCommonQuery objServ = null;
            try
            {
                objServ = (clsCommonQuery)com.digitalwave.iCare.common.clsObjectGenerator.objCreatorObjectByType(typeof(clsCommonQuery));
                lngRes = objServ.m_lngUpdateRequisitionMR(p_strRgno, p_strOpreationName, p_strANAName, p_strANADate, p_strEmployID, p_strEmployName);
            }
            catch (Exception exp)
            {
                Utility.clsLogText objLogger = new Utility.clsLogText();
                objLogger.LogError("�����м�������쳣��" + exp.Message);
            }
            finally
            {
                if (objServ != null)
                {
                    objServ.Dispose();
                    objServ = null;
                }
            }
            #endregion
            return lngRes;
        }
        #endregion

        #region ����籣�����籣����û�гɹ��Ͳ�����HIS����
        /// <summary>
        /// ����籣�����籣����û�гɹ��Ͳ�����HIS����
        /// </summary>
        /// <param name="p_registerID"></param>
        /// <returns></returns>
        public bool m_blnCheckYBChargeSuccessFull(string p_registerID)
        {
            bool blnSucc = false;

            #region �м������
            clsCharge objServ = null;
            try
            {
                objServ = (clsCharge)com.digitalwave.iCare.common.clsObjectGenerator.objCreatorObjectByType(typeof(clsCharge));
                blnSucc = objServ.m_blnCheckYBChargeSuccessFull(p_registerID);
            }
            catch (Exception exp)
            {
                Utility.clsLogText objLogger = new Utility.clsLogText();
                objLogger.LogError("�����м�������쳣��" + exp.Message);
            }
            finally
            {
                if (objServ != null)
                {
                    objServ.Dispose();
                    objServ = null;
                }
            }
            #endregion
            return blnSucc;
        }
        #endregion

        #region ��˷���

        #region ��ȡ���߷��������Ϣ
        /// <summary>
        /// ��ȡ���߷��������Ϣ
        /// </summary>
        /// <param name="registerId"></param>
        /// <returns></returns>
        public DataTable GetPatientCheckFee(string registerId)
        {
            using (com.digitalwave.iCare.middletier.HIS.clsCharge svc = (com.digitalwave.iCare.middletier.HIS.clsCharge)com.digitalwave.iCare.common.clsObjectGenerator.objCreatorObjectByType(typeof(com.digitalwave.iCare.middletier.HIS.clsCharge)))
            {
                return svc.GetPatientCheckFee(registerId);
            }
        }
        #endregion

        #region ���滼�߷��������Ϣ
        /// <summary>
        /// ���滼�߷��������Ϣ
        /// </summary>
        /// <param name="registerId"></param>
        /// <param name="operId"></param>
        /// <returns></returns>
        public int SavePatientCheckFee(string registerId, string operId)
        {
            using (com.digitalwave.iCare.middletier.HIS.clsCharge svc = (com.digitalwave.iCare.middletier.HIS.clsCharge)com.digitalwave.iCare.common.clsObjectGenerator.objCreatorObjectByType(typeof(com.digitalwave.iCare.middletier.HIS.clsCharge)))
            {
                return svc.SavePatientCheckFee(registerId, operId);
            }
        }
        #endregion

        #region ȡ�����߷��������Ϣ
        /// <summary>
        /// ȡ�����߷��������Ϣ
        /// </summary>
        /// <param name="registerId"></param>
        /// <param name="operId"></param>
        /// <returns></returns>
        public int CancelPatientCheckFee(string registerId, string operId)
        {
            using (com.digitalwave.iCare.middletier.HIS.clsCharge svc = (com.digitalwave.iCare.middletier.HIS.clsCharge)com.digitalwave.iCare.common.clsObjectGenerator.objCreatorObjectByType(typeof(com.digitalwave.iCare.middletier.HIS.clsCharge)))
            {
                return svc.CancelPatientCheckFee(registerId, operId);
            }
        }
        #endregion

        #endregion

        #region �ѷ�(��)�ڷ�ҩ�������˷�
        /// <summary>
        /// �ѷ�(��)�ڷ�ҩ�������˷�
        /// </summary>
        /// <param name="pchargeId"></param>
        /// <returns></returns>
        public bool IsCanRefundment(string pchargeId)
        {
            using (com.digitalwave.iCare.middletier.HIS.clsCharge svc = (com.digitalwave.iCare.middletier.HIS.clsCharge)com.digitalwave.iCare.common.clsObjectGenerator.objCreatorObjectByType(typeof(com.digitalwave.iCare.middletier.HIS.clsCharge)))
            {
                return svc.IsCanRefundment(pchargeId);
            }
        }
        #endregion

        #region ������ɫ����

        #region GetEmpInfo
        /// <summary>
        /// GetEmpInfo
        /// </summary>
        /// <param name="empNo"></param>
        /// <returns></returns>
        public DataTable GetEmpInfo(string empNo)
        {
            using (com.digitalwave.iCare.middletier.HIS.clsCharge svc = (com.digitalwave.iCare.middletier.HIS.clsCharge)com.digitalwave.iCare.common.clsObjectGenerator.objCreatorObjectByType(typeof(com.digitalwave.iCare.middletier.HIS.clsCharge)))
            {
                return svc.GetEmpInfo(empNo);
            }
        }
        #endregion

        #region AddCaseRole
        /// <summary>
        /// AddCaseRole
        /// </summary>
        /// <param name="vo"></param>
        /// <returns></returns>
        public int AddCaseRole(EntityLogSetCaseRole vo)
        {
            using (com.digitalwave.iCare.middletier.HIS.clsCharge svc = (com.digitalwave.iCare.middletier.HIS.clsCharge)com.digitalwave.iCare.common.clsObjectGenerator.objCreatorObjectByType(typeof(com.digitalwave.iCare.middletier.HIS.clsCharge)))
            {
                return svc.AddCaseRole(vo);
            }
        }
        #endregion

        #region DelCaseRole
        /// <summary>
        /// DelCaseRole
        /// </summary>
        /// <param name="vo"></param>
        /// <returns></returns>
        public int DelCaseRole(EntityLogSetCaseRole vo)
        {
            using (com.digitalwave.iCare.middletier.HIS.clsCharge svc = (com.digitalwave.iCare.middletier.HIS.clsCharge)com.digitalwave.iCare.common.clsObjectGenerator.objCreatorObjectByType(typeof(com.digitalwave.iCare.middletier.HIS.clsCharge)))
            {
                return svc.DelCaseRole(vo);
            }
        }
        #endregion

        #region QueryCaseRole
        /// <summary>
        /// QueryCaseRole
        /// </summary>
        /// <param name="startDate"></param>
        /// <param name="endDate"></param>
        /// <param name="doctCode"></param>
        /// <returns></returns>
        public DataTable QueryCaseRole(string startDate, string endDate, string doctCode)
        {
            using (com.digitalwave.iCare.middletier.HIS.clsCharge svc = (com.digitalwave.iCare.middletier.HIS.clsCharge)com.digitalwave.iCare.common.clsObjectGenerator.objCreatorObjectByType(typeof(com.digitalwave.iCare.middletier.HIS.clsCharge)))
            {
                return svc.QueryCaseRole(startDate, endDate, doctCode);
            }
        }
        #endregion

        #region ��ѯ��Ʊ�˿�ԭ��ģ��
        /// <summary>
        /// ��ѯ��Ʊ�˿�ԭ��ģ��
        /// </summary>
        /// <param name="flagId"></param>
        /// <returns></returns>
        public DataTable GetRefundReasonList(int flagId)
        {
            using (com.digitalwave.iCare.middletier.HIS.clsCharge svc = (com.digitalwave.iCare.middletier.HIS.clsCharge)com.digitalwave.iCare.common.clsObjectGenerator.objCreatorObjectByType(typeof(com.digitalwave.iCare.middletier.HIS.clsCharge)))
            {
                return svc.GetRefundReasonList(flagId);
            }
        }
        #endregion

        #region ��ѯ��Ʊ�˿�ԭ��
        /// <summary>
        /// ��ѯ��Ʊ�˿�ԭ��
        /// </summary>
        /// <param name="flagId"></param>
        /// <param name="invoNo"></param>
        /// <returns></returns>
        public EntityInvoiceRefundReason GetInvoiceRefundReason(int flagId, string invoNo)
        {
            using (com.digitalwave.iCare.middletier.HIS.clsCharge svc = (com.digitalwave.iCare.middletier.HIS.clsCharge)com.digitalwave.iCare.common.clsObjectGenerator.objCreatorObjectByType(typeof(com.digitalwave.iCare.middletier.HIS.clsCharge)))
            {
                return svc.GetInvoiceRefundReason(flagId, invoNo);
            }
        }
        #endregion

        #region ���淢Ʊ�˿�ԭ��
        /// <summary>
        /// ���淢Ʊ�˿�ԭ��
        /// </summary>
        /// <param name="vo"></param>
        /// <returns></returns>
        public int SaveInvoiceRefundReason(EntityInvoiceRefundReason vo)
        {
            using (com.digitalwave.iCare.middletier.HIS.clsCharge svc = (com.digitalwave.iCare.middletier.HIS.clsCharge)com.digitalwave.iCare.common.clsObjectGenerator.objCreatorObjectByType(typeof(com.digitalwave.iCare.middletier.HIS.clsCharge)))
            {
                return svc.SaveInvoiceRefundReason(vo);
            }
        }
        #endregion

        #endregion
    }
}
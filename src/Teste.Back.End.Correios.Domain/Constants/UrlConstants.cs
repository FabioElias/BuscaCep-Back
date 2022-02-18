namespace Atendimento.Cliente.Bff.For.Order.Domain.Constants
{
    public static class UrlConstants
    {
        public static class HttpOrder
        {
            public const string ServiceKey = "Orders";

            public static class GetOrderByOrderCode
            {
                public const string MethodKey = "GetOrderByOrderCode";
                public const string PathParam_OrderCode = "numeroPedido";
            }

            public static class GetOrderBySequentialNumber
            {
                public const string MethodKey = "GetOrderBySequentialNumber";
                public const string PathParam_SequentialNumber = "numeroSequencial";
            }

            public static class GetOrderByDocument
            {
                public const string MethodKey = "GetOrderByDocument";
                public const string PathParam_Document = "cpf";
                public const string QueryParam_OrderStatusCode = "codigoSituacaoPedido";
                public const string QueryParam_Page = "page";
                public const string QueryParam_Size = "size";
                public const string QueryParam_InitialDate = "dataInicio";
                public const string QueryParam_FinalDate = "dataFim";
                public const string QueryParam_OrderNumber = "numeroPedido";
            }

            public static class GetOrderByMail
            {
                public const string MethodKey = "GetOrderByMail";
                public const string PathParam_Mail = "email";
                public const string QueryParam_OrderStatusCode = "codigoSituacaoPedido";
                public const string QueryParam_Page = "page";
                public const string QueryParam_Size = "size";
                public const string QueryParam_InitialDate = "dataInicio";
                public const string QueryParam_FinalDate = "dataFim";
                public const string QueryParam_OrderNumber = "numeroPedido";
            }

            public static class GetSelllerByOrderCode
            {
                public const string MethodKey = "GetSellerByOrderCode";
                public const string PathParam_OrderCode = "numeroPedido";
            }

            public static class GetItemsByOrderCode
            {
                public const string MethodKey = "GetItemsByOrderCode";
                public const string PathParam_OrderCode = "numeroPedido";
            }

            public static class GetItemsBySequenceNumber
            {
                public const string MethodKey = "GetItemsBySequenceNumber";
                public const string PathParam_SequenceNumber = "numeroSequencial";
            }

            public static class GetDeliveryDetialsByOrderCode
            {
                public const string MethodKey = "GetDeliveryDetailsByOrderCode";
                public const string PathParam_OrderCode = "numeroPedido";
            }

            public static class GetPaymentMethodsByOrderCode
            {
                public const string MethodKey = "GetPaymentMethodsByOrderCode";
                public const string PathParam_OrderCode = "numeroPedido";
            }

            public static class GetOrderSituation
            {
                public const string MethodKey = "GetOrderSituation";
            }

            public static class GetCustomerByOrderCode
            {
                public const string MethodKey = "GetCustomerByOrderCode";
                public const string PathParam_OrderCode = "numeroPedido";
            }
        }

        public static class HttpRefund
        {
            public const string ServiceKey = "Refund";

            public static class GetRefund
            {
                public const string MethodKey = "GetRefund";
                public const string PathParam_RefundCode = "numeroPedido";
            }

            public static class GetRefundItem
            {
                public const string MethodKey = "GetRefundItem";
                public const string PathParam_RefundItemCode = "id";
            }
        }
    }
}

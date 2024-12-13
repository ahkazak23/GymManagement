using System;
using System.Collections.Generic;
using DAL.Repositories;
using Models.Entities;

namespace BLL.Managers
{
    public class PaymentManager
    {
        private readonly PaymentRepository _paymentRepository;

        public PaymentManager()
        {
            _paymentRepository = new PaymentRepository();
        }

        /// <summary>
        /// Adds a new payment for a member.
        /// </summary>
        /// <param name="payment">The payment object containing payment details.</param>
        /// <exception cref="ArgumentException">Thrown if payment details are invalid.</exception>
        public void AddPayment(Payment payment)
        {
            ValidatePayment(payment);

            _paymentRepository.AddPayment(payment);
        }

        /// <summary>
        /// Updates the status of an existing payment.
        /// </summary>
        /// <param name="paymentId">The ID of the payment to update.</param>
        /// <param name="status">The new status of the payment.</param>
        /// <exception cref="ArgumentException">Thrown if the PaymentID or status is invalid.</exception>
        public void UpdatePaymentStatus(int paymentId, string status)
        {
            if (paymentId <= 0)
            {
                throw new ArgumentException("Invalid PaymentID.");
            }

            if (!IsValidPaymentStatus(status))
            {
                throw new ArgumentException($"Invalid payment status: {status}");
            }

            _paymentRepository.UpdatePaymentStatus(paymentId, status);
        }

        /// <summary>
        /// Retrieves all payments for a specific member.
        /// </summary>
        /// <param name="memberId">The ID of the member.</param>
        /// <returns>A list of payments for the specified member.</returns>
        /// <exception cref="ArgumentException">Thrown if the MemberID is invalid.</exception>
        public List<Payment> GetPaymentsByMemberId(int memberId)
        {
            if (memberId <= 0)
            {
                throw new ArgumentException("Invalid MemberID.");
            }

            return _paymentRepository.GetPaymentsByMemberId(memberId);
        }

        /// <summary>
        /// Retrieves all overdue payments in the system.
        /// </summary>
        /// <returns>A list of overdue payments.</returns>
        public List<Payment> GetOverduePayments()
        {
            return _paymentRepository.GetOverduePayments();
        }

        /// <summary>
        /// Validates a payment object.
        /// </summary>
        /// <param name="payment">The payment object to validate.</param>
        /// <exception cref="ArgumentException">Thrown if any payment details are invalid.</exception>
        private void ValidatePayment(Payment payment)
        {
            if (payment.Amount <= 0)
            {
                throw new ArgumentException("Payment amount must be greater than zero.");
            }

            if (payment.PaymentDate > DateTime.Now)
            {
                throw new ArgumentException("Payment date cannot be in the future.");
            }

            if (!IsValidPaymentStatus(payment.Status))
            {
                throw new ArgumentException($"Invalid payment status: {payment.Status}");
            }

            if (payment.MemberID <= 0)
            {
                throw new ArgumentException("Invalid MemberID.");
            }
        }

        /// <summary>
        /// Checks if a payment status is valid.
        /// </summary>
        /// <param name="status">The payment status to check.</param>
        /// <returns>True if the status is valid; otherwise, false.</returns>
        private bool IsValidPaymentStatus(string status)
        {
            return PaymentStatus.ValidStatuses.Contains(status);
        }
    }

    /// <summary>
    /// Defines valid payment statuses.
    /// </summary>
    public static class PaymentStatus
    {
        public const string Paid = "Paid";
        public const string Overdue = "Overdue";
        public const string Pending = "Pending";

        public static readonly HashSet<string> ValidStatuses = new HashSet<string> { Paid, Overdue, Pending };
    }

}

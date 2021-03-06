﻿namespace Fasetto.Word
{
    using System;
    using System.Globalization;

    /// <inheritdoc/>
    /// <summary>
    /// Takes a date and converts it to a user friendly date/time
    /// </summary>
    public class TimeToReadTimeConverter : BaseValueConverter<TimeToReadTimeConverter>
    {
        #region Public Methods

        /// <inheritdoc/>
        /// <summary>
        /// Convert a time to display friendly format
        /// </summary>
        /// <param name="value">The original time value</param>
        /// <param name="targetType">The type to convert to</param>
        /// <param name="parameter">Any parameters passed</param>
        /// <param name="culture">The language culture</param>
        /// <returns>The <see cref="T:System.Windows.Visibility"/>. value</returns>
        public override object Convert(object value, Type targetType, object parameter, CultureInfo culture)
        {
            // Get the time passed in
            var time = (DateTimeOffset)value;

            // If it is not read...
            if (time == DateTimeOffset.MinValue)
                // Show nothing
                return string.Empty;

            // If it is today...
            if (time.Date == DateTimeOffset.UtcNow.Date)
                // Return just time
                return $"Read {time.ToLocalTime().ToString("HH:mm:ss")}";

            // Otherwise, return a full date
            return $"Read {time.ToLocalTime().ToString("HH:mm:ss, dd MMM yyyy")}";
        }

        /// <inheritdoc/>
        /// <summary>
        /// Not used
        /// </summary>
        /// <param name="value">The <see cref="T:System.Windows.Visibility"/> value</param>
        /// <param name="targetType">The TargetType of the action to target</param>
        /// <param name="parameter">Any parameters passed</param>
        /// <param name="culture">The language culture</param>
        /// <returns>The <see cref="T:System.Boolean"/> value of this property</returns>
        /// <exception cref="T:System.NotImplementedException">
        /// We have not implemented this yet
        /// </exception>
        public override object ConvertBack(object value, Type targetType, object parameter, CultureInfo culture)
        {
            throw new NotImplementedException();
        }

        #endregion Public Methods
    }
}
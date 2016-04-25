// ***********************************************************************
// Assembly         : SchemaReader
// Author           : James Rafferty
// Created          : 04-25-2016
//
// Last Modified By : James Rafferty
// Last Modified On : 04-25-2016
// ***********************************************************************
// <copyright file="SchemaField.cs" company="Bernalillo County Public Works">
//     Copyright © Bernalillo County Public Works 2016
// </copyright>
// <summary>Schema information for a field.</summary>
// ***********************************************************************

using System.ComponentModel;
using System.Runtime.CompilerServices;
using SchemaReader.Annotations;

namespace SchemaReader
{
    /// <summary>
    /// Class SchemaField.
    /// </summary>
    /// <seealso cref="System.ComponentModel.INotifyPropertyChanged" />
    internal class SchemaField : INotifyPropertyChanged
    {
        /// <summary>
        /// The field position
        /// </summary>
        private int _fieldPosition;
        /// <summary>
        /// The field name
        /// </summary>
        private string _fieldName;
        /// <summary>
        /// The field type
        /// </summary>
        private string _fieldType;
        /// <summary>
        /// The max length
        /// </summary>
        private int _maxLength;
        /// <summary>
        /// The character sample
        /// </summary>
        private string _characterSample;
        /// <summary>
        /// The precision sample
        /// </summary>
        private string _precisionSample;
        /// <summary>
        /// The scale sample
        /// </summary>
        private string _scaleSample;

        /// <summary>
        /// Gets or sets the field position. This is the field's column index within the feature class.
        /// </summary>
        /// <value>The field position.</value>
        internal int FieldPosition
        {
            get { return _fieldPosition; }
            set
            {
                _fieldPosition = value;
                OnPropertyChanged();
            }
        }

        /// <summary>
        /// Gets or sets the name of the field.
        /// </summary>
        /// <value>The name of the field.</value>
        internal string FieldName
        {
            get { return _fieldName; }
            set
            {
                _fieldName = value;
                OnPropertyChanged();
            }
        }

        /// <summary>
        /// Gets or sets the ESRI data type of the field.
        /// </summary>
        /// <value>The type of the field.</value>
        internal string FieldType
        {
            get { return _fieldType; }
            set
            {
                _fieldType = value;
                OnPropertyChanged();
            }
        }

        /// <summary>
        /// Gets or sets the maximum length of the field.
        /// </summary>
        /// <value>The maximum length.</value>
        internal int MaxLength
        {
            get { return _maxLength; }
            set
            {
                _maxLength = value;
                OnPropertyChanged();
            }
        }

        /// <summary>
        /// Gets or sets the character sample.
        /// </summary>
        /// <value>The character sample.</value>
        internal string CharacterSample
        {
            get { return _characterSample; }
            set
            {
                _characterSample = value;
                OnPropertyChanged();
            }
        }

        /// <summary>
        /// Gets or sets the precision sample.
        /// </summary>
        /// <value>The precision sample.</value>
        internal string PrecisionSample
        {
            get { return _precisionSample; }
            set
            {
                _precisionSample = value;
                OnPropertyChanged();
            }
        }

        /// <summary>
        /// Gets or sets the scale sample.
        /// </summary>
        /// <value>The scale sample.</value>
        internal string ScaleSample
        {
            get { return _scaleSample; }
            set
            {
                _scaleSample = value;
                OnPropertyChanged();
            }
        }

        /// <summary>
        /// Occurs when a property value changes.
        /// </summary>
        public event PropertyChangedEventHandler PropertyChanged;

        /// <summary>
        /// Called when [property changed].
        /// </summary>
        /// <param name="propertyName">Name of the property.</param>
        [NotifyPropertyChangedInvocator]
        protected virtual void OnPropertyChanged([CallerMemberName] string propertyName = null)
        {
            PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(propertyName));
        }
    }
}

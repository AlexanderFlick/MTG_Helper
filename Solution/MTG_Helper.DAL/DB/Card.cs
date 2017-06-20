//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated from a template.
//
//     Manual changes to this file may cause unexpected behavior in your application.
//     Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace MTG_Helper.DAL.DB
{
    using System;
    using System.Collections.Generic;
    
    public partial class Card
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public Card()
        {
            this.CardColors = new HashSet<CardColor>();
            this.CardSets = new HashSet<CardSet>();
            this.CardSubTypes = new HashSet<CardSubType>();
            this.CardTypes = new HashSet<CardType>();
            this.Decks = new HashSet<Deck>();
            this.DeckCards = new HashSet<DeckCard>();
        }
    
        public string CardId { get; set; }
        public string CardName { get; set; }
        public string Url { get; set; }
        public string StoreUrl { get; set; }
        public string ConvertedManaCost { get; set; }
        public string Cost { get; set; }
        public string RulesText { get; set; }
        public string Power { get; set; }
        public string Toughness { get; set; }
        public string Commander { get; set; }
        public string Legacy { get; set; }
        public string Modern { get; set; }
        public string Standard { get; set; }
        public string Vintage { get; set; }
        public string Types { get; set; }
        public string SubTypes { get; set; }
        public string Colors { get; set; }
    
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<CardColor> CardColors { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<CardSet> CardSets { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<CardSubType> CardSubTypes { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<CardType> CardTypes { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<Deck> Decks { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<DeckCard> DeckCards { get; set; }
    }
}

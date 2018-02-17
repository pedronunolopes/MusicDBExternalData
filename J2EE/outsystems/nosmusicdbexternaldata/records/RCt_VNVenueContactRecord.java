package outsystems.nosmusicdbexternaldata.records;

import java.io.Serializable;
import java.sql.*;
import java.math.BigDecimal;
import java.util.BitSet;
import org.w3c.dom.*;
import outsystems.objectkeys.*;
import outsystems.runtimecommon.*;
import outsystems.hubedition.runtimeplatform.*;
import outsystems.hubedition.runtimeplatform.db.*;
import outsystems.internal.db.*;
import outsystems.hubedition.databaseabstractionlayer.adoadapters.*;
import outsystems.hubedition.util.*;
import outsystems.hubedition.runtimeplatform.newruntime.*;
import outsystems.nosmusicdbexternaldata.records.*;

import outsystems.nosmusicdbexternaldata.entities.*;
import outsystems.nosmusicdbexternaldata.structures.*;
import outsystems.nosmusicdbexternaldata.recordlists.*;


public class RCt_VNVenueContactRecord implements Serializable, Cloneable, ITypedRecord<RCt_VNVenueContactRecord> {

	private static final GlobalObjectKey Idt_VNVenueContact = GlobalObjectKey.parse("2UmDmepsh0WSfJ_D1JexCA*wStZMrieEBQxTDFZIwP6jw");

	public static void ensureInitialized() {}
	public ENt_VNVenueContactEntityRecord ssENt_VNVenueContact;


	/**
	 *
	 * Get Structure instance
	 *
	 * @return  The structure
	 */
	public ENt_VNVenueContactEntityRecord toStructure() {
		return ssENt_VNVenueContact;
	}

	/**
	 *
	 * Constructor
	 *
	 * @param  r
	 *         The base structure
	 */
	public RCt_VNVenueContactRecord(ENt_VNVenueContactEntityRecord r) throws Exception {
		ssENt_VNVenueContact = (ENt_VNVenueContactEntityRecord)
		r.clone();
	}

	public void setChangedAttributes(BitSet value) {
		ssENt_VNVenueContact.ChangedAttributes = value;
	}
	public BitSet getChangedAttributes() {
		return ssENt_VNVenueContact.ChangedAttributes;
	}
	public BitSet OptimizedAttributes;

	/**
	 *
	 * Default Constructor
	 */
	public RCt_VNVenueContactRecord() {
		OptimizedAttributes = null;
		ssENt_VNVenueContact = new ENt_VNVenueContactEntityRecord();
	}

	public BitSet[] getDefaultOptimizedValues() {
		BitSet[] all = new BitSet[1];
		all[0] = BitSetUtils.newInstance(4, false);
		return all;
	}

	public void setAllOptimizedAttributes(BitSet[] value) {
		if (value == null) {
			ssENt_VNVenueContact.OptimizedAttributes = getDefaultOptimizedValues()[0];
		} else {
			ssENt_VNVenueContact.OptimizedAttributes = value[0];
		}
	}
	public BitSet[] getAllOptimizedAttributes() {
		BitSet[] all = new BitSet[1];
		all[0] = ssENt_VNVenueContact.OptimizedAttributes;
		return all;
	}

	/**
	 *
	 * Read a record from database
	 *
	 * @param  r
	 *         Data base reader
	 * @param  index
	 *         index
	 */
	public int read(OSResultSet r, int index) throws ClassCastException {
		index = ssENt_VNVenueContact.read(r, index);
		return index;
	}
	/**
	 *
	 * Read from database
	 *
	 * @param  r
	 *         Data reader
	 */
	public void readDB(OSResultSet r) {
		int index = 0;
		read(r, index);
	}

	/**
	 *
	 * Read from record
	 *
	 * @param  r
	 *         Record
	 */
	public void readIM(RCt_VNVenueContactRecord r) throws Exception {
		this.ssENt_VNVenueContact = (ENt_VNVenueContactEntityRecord) r.ssENt_VNVenueContact.duplicate();
	}


	/**
	 *
	 * Comparison Function
	 *
	 * @param  obj
	 *         Object to compare to.
	 *
	 * @return  True if equal
	 */
	public boolean equals(Object obj) {
		if ((obj == null) || !(obj instanceof RCt_VNVenueContactRecord)) {
			return false;
		}
		RCt_VNVenueContactRecord b = (RCt_VNVenueContactRecord) obj;
		if (!this.ssENt_VNVenueContact.equals(b.ssENt_VNVenueContact)) return false;
		return true;
	}

	/**
	 *
	 * Hash Value Function
	 *
	 * @return  A hash value for the instance
	 */
	public int hashCode() {
		try {
			return super.hashCode() ^ ssENt_VNVenueContact.hashCode();
		} catch (NullPointerException e) {
			return super.hashCode();
		}
	}

	/**
	 *
	 * Performs a Recursive Reset in the instance
	 */
	public void recursiveReset() throws Exception {
		ssENt_VNVenueContact.recursiveReset();
	}

	/**
	 *
	 * Performs a internal Recursive Reset in the instance
	 */
	public void internalRecursiveSave() throws Exception {
		ssENt_VNVenueContact.internalRecursiveSave();
	}

	/**
	 *
	 * Returns a duplicate/clone instance
	 *
	 * @return  Duplicate Instance
	 */
	public RCt_VNVenueContactRecord duplicate() throws Exception {
		RCt_VNVenueContactRecord t = new RCt_VNVenueContactRecord();
		t.ssENt_VNVenueContact = (ENt_VNVenueContactEntityRecord) this.ssENt_VNVenueContact.duplicate();
		t.OptimizedAttributes = null;
		return t;
	}

	public IRecord duplicate$IRecord() throws Exception {
		return duplicate();
	}
	public void toXml(Object parent, Element baseElem, String fieldName, int detailLevel) {
		Element recordElem = VarValue.appendChild(baseElem, "Record");
		if (fieldName != null) {
			VarValue.appendAttribute(recordElem, "debug.field", fieldName);
		}
		if (detailLevel > 0) {
			ssENt_VNVenueContact.toXml(this, recordElem, "t_VNVenueContact", detailLevel - 1);
		} else {
			VarValue.appendDeferredEvaluationElement(recordElem);
		}
	}

	public void evaluateFields(VarValue variable, Object parent, String baseName, String fields) throws java.lang.reflect.InvocationTargetException, IllegalAccessException, IllegalArgumentException {
		String head = VarValue.getHead(fields);
		String tail = VarValue.getTail(fields);
		variable.setFound(false);
		if (head.equals("t_vnvenuecontact")) {
			if (!VarValue.fieldIsOptimized(parent, baseName + ".t_VNVenueContact")) variable.setValue(ssENt_VNVenueContact); else variable.setOptimized(true);
			variable.setFieldName("t_vnvenuecontact");
		}
		if (variable.isFound() && tail != null) variable.evaluateFields(this, head, tail);
	}

	public Object clone() throws CloneNotSupportedException {
		RCt_VNVenueContactRecord t = (RCt_VNVenueContactRecord) super.clone();
		t.ssENt_VNVenueContact = (ENt_VNVenueContactEntityRecord) this.ssENt_VNVenueContact.clone();
		return t;
	}

	public boolean changedAttributeGet(GlobalObjectKey key) throws Exception {
		return ssENt_VNVenueContact.changedAttributeGet(key);
	}

	public boolean optimizedAttributeGet(GlobalObjectKey key) throws Exception {
		return ssENt_VNVenueContact.optimizedAttributeGet(key);
	}

	public Object attributeGet(GlobalObjectKey key) throws Exception {
		if (key.equals(Idt_VNVenueContact)) {
			return ssENt_VNVenueContact;
		} else {
			throw new Exception("Invalid key");
		}
	}
	public void fillFromOther(IRecord other) throws Exception {
		if (other == null) return;
		ssENt_VNVenueContact.fillFromOther((IRecord) other.attributeGet(Idt_VNVenueContact));
	}
}
